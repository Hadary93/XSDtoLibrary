using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using Templates;

namespace XSDtoLibrary.Generators
{
    /// <summary>
    /// A Class to generate test cases for all Schemas provided.
    /// </summary>
    public class TestGenerator
    {
        private string DLLpath { get; set; }
        private string SchemasFolder { get; set; }  
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dllPath">library dll path for reflection</param>
        /// <param name="schemasFolder">schema files folder path</param>
        public TestGenerator(string dllPath, string schemasFolder)
        { 
            DLLpath = dllPath;
            SchemasFolder = schemasFolder;    
            GenerateTestCases(schemasFolder);
        } 
        /// <summary>
        /// Generate test cases for all Schema files.
        /// </summary>
        /// <param name="schemasFolder">schemas folder path</param>
        private void GenerateTestCases(string schemasFolder)
        {

            foreach(var file in Directory.GetFiles(schemasFolder))
            {
                XmlReader xmlReader = XmlReader.Create(file);
                XElement xElement = XElement.Load(xmlReader);

                var NameSpace = Helper.GetNameSpaceLastName(xElement.Attribute("targetNamespace")?.Value);
                var XSDdeclaredTypes = xElement.Elements().Where(x => x.Name.LocalName.Equals("element")).Select(x => x.Attribute("type")?.Value.Replace(":", "."));

                Assembly assembly = Assembly.LoadFrom(DLLpath);
                var typesByNamespace = assembly.GetTypes()
                    .Where(t => t.IsClass && t.Namespace != null && t.Namespace.Equals(NameSpace));

                var content = $"using {NameSpace};\r\nusing System.Xml.Schema;\r\nusing System.Xml;\r\nusing System.Xml.Serialization;\n"; ;

                content += $"public class {Helper.UpperCase(NameSpace)}\n";
                content += $"{{\n";
                content += $"\tprivate string ValidationOutput {{get;set;}}\n\tprivate StringWriter writer = new StringWriter();\r\n\tprivate XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();";
                content += AddCallBackFunction();
                content += AddValidateFunction();

   
                content += TestFile(typesByNamespace, file);
                

                content += $"\n}}";

                Helper.MakeFile($"{Helper.FindSolutionPath()}/LibraryTest",content, NameSpace);

            }    
        }
        /// <summary>
        /// Create the content of a test file relative to a schema file.
        /// </summary>
        /// <param name="classesGroup">all types inside a name space with the same name of schema file.</param>
        /// <param name="schemaFile">schema file path</param>
        /// <returns>test file content</returns>
        private string TestFile(IEnumerable<Type> classesGroup,string schemaFile)
        {
            var content = string.Empty;

            foreach (var classType in classesGroup)
            {
                if (!classType.IsPrimitive && classType.IsClass)
                {
                    XmlReader xmlReader = XmlReader.Create(schemaFile);
                    XElement xElement = XElement.Load(xmlReader);

                    var decalred = xElement.Elements().FirstOrDefault(x =>
                    {

                        if (x.Name.LocalName.Equals("element"))
                        {
                            var nameAttr = x.Attribute("name")?.Value;
                            if (nameAttr != null && nameAttr.ToUpper().Equals(classType.Name.ToUpper()))
                            {
                                return true;
                            }
                        }
                        return false;
                    });

                    if (decalred != null)
                    {
                        content += TestCase(classType, schemaFile);
                    } 
                }
            }
            return content;
        }
        /// <summary>
        /// Single test case of each Class.
        /// </summary>
        /// <param name="type">class type</param>
        /// <param name="schemaFile">schema file Path</param>
        /// <returns>test case content</returns>
        private string TestCase(Type type,string schemaFile)
        {
            var content = $"\n\t[Fact]\n";

            content += $"\tpublic void {type.Name}()\n";
            content += $"\t{{\n";

            content += $"\t\t{type.FullName} {Helper.LowerCase(type.Name)} = new ();\n";

            foreach (PropertyInfo property in type.GetProperties())
            {


                content += $"\t\t{Helper.LowerCase(type.Name)}.{property.Name} = {FillProperty(property,type.Name, schemaFile)} ;\n";

                var choice = ChoiceProperties(type.Name, schemaFile);

                if (choice) break;
            }

            content += $"\t\tvar serializer = new XmlSerializer(typeof({type.Name}));\n";
            content += $"\t\tserializer.Serialize(writer, {Helper.LowerCase(type.Name)}, namespaces);\n";
            content += $"\t\tstring xml = writer.ToString();\n";
            content += $"\t\tvalidate(xml);\n";
            content += $"\t\tAssert.Equal(\"\",ValidationOutput);\n";

            content += $"\t}}";

            return content;
        }
        /// <summary>
        /// Fill a property with a value for testing.
        /// </summary>
        /// <param name="property">PropertyInfo</param>
        /// <param name="className">class name</param>
        /// <param name="schemaFile">schema file Path</param>
        /// <returns></returns>
        private string FillProperty(PropertyInfo property,string className,string schemaFile)
        {
            if (property.PropertyType.IsPrimitive)
            {
                switch (property.PropertyType.Name)
                {
                    case "UInt32":
                        return "100";
                    case "Int32":
                        return "100";
                    case "Double":
                        return "100.0";
                    case "Boolean":
                        return "true";
                    default:
                        break;
                }
            }
            else
            {
                if (property.PropertyType.Name.Equals("String"))
                {
                    var type = SchemaType(className, property.Name, schemaFile);

                    if (type!=null && type.Equals("xs:date"))
                    {
                        return "\"2024-01-01\"";
                    }
                    return "\"\"";
                }

                return FillNonPrimitive(property.PropertyType,schemaFile);
            }
            return string.Empty;
        }
        /// <summary>
        /// Fill a non primitive property
        /// </summary>
        /// <param name="type"></param>
        /// <param name="schemaFile"></param>
        /// <returns></returns>
        private string FillNonPrimitive(Type type,string schemaFile)
        {
           
            var content = $"new(){{";

            foreach (PropertyInfo property in type.GetProperties())
            {
                content += $" {property.Name} = {FillProperty(property,type.Name, schemaFile)} ,";

                var choice = ChoiceProperties(type.Name, schemaFile);

                if (choice) break;
            }

            content += $"}}";

            return content;
        }
        /// <summary>
        /// Check if a property is included in a choice in XSD.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="schemaPath"></param>
        /// <returns></returns>
        private bool ChoiceProperties(string className,string schemaPath)
        {
            var element =  GetElement(className,schemaPath);

            var choice = element?.Descendants().FirstOrDefault(x => x.Name.LocalName.Equals("choice"));

            return choice != null?true:false;
        }
        /// <summary>
        /// Get the type of an property form the schema.
        /// </summary>
        /// <param name="className">class name including the property</param>
        /// <param name="propertyName">property name</param>
        /// <param name="schemaPath">schema file path</param>
        /// <returns>type of the property in the xsd</returns>
        private string? SchemaType(string className, string propertyName, string schemaPath)
        {
            var element = GetElement(className, schemaPath);

            var type = element?.Descendants().FirstOrDefault(x =>
            {
                var nameAttr = x.Attribute("name")?.Value;

                if (nameAttr != null && nameAttr.Equals(propertyName)) return true;

                return false;
            })?.Attribute("type")?.Value;

            return type;
        }
        /// <summary>
        /// Get an element from the schema file.
        /// </summary>
        /// <param name="className">class name</param>
        /// <param name="schemaPath">schema file path</param>
        /// <returns>element in the xsd</returns>
        private XElement? GetElement(string className, string schemaPath)
        {
            XmlReader xmlReader = XmlReader.Create(schemaPath);
            XElement xElement = XElement.Load(xmlReader);

            var element = xElement.Elements().FirstOrDefault(x => {

                var nameAttr = x.Attribute("name")?.Value;

                if (x.Name.LocalName.Equals("complexType") && nameAttr != null && nameAttr.Equals(className)) return true;

                return false;

            });
            return element;
        }

        private string AddCallBackFunction()
        {

            return $"\n        private void ValidationCallback(object sender, System.Xml.Schema.ValidationEventArgs e)\r\n        {{\r\n            \r\n            if (e.Severity == XmlSeverityType.Warning)\r\n            {{\r\n                ValidationOutput +=  e.Message;\r\n            }}\r\n            else if (e.Severity == XmlSeverityType.Error)\r\n            {{\r\n                ValidationOutput += e.Message;\r\n            }}\r\n        }}";
        }

        private string AddValidateFunction()
        {
            var content = "\n        private void validate(string xml)\r\n        {\r\n            // Create an instance of XmlReaderSettings\r\n            var settings = new XmlReaderSettings();\r\n\r\n            // Enable XML schema validation\r\n            settings.ValidationType = ValidationType.Schema;\r\n\r\n            // Set the schema to validate against\r\n";

            foreach (var file in Directory.GetFiles(SchemasFolder))
            {
                content += $"\t\tsettings.Schemas.Add(null, \"{file.Split("\\")[^1]}\");\r\n";
            }

            content += "\t\t// Attach the validation event handler\r\n            settings.ValidationEventHandler += ValidationCallback;\r\n\r\n\r\n            // Create an instance of XmlReader with the XML file and settings\r\n            using (var reader = XmlReader.Create(new StringReader(xml), settings))\r\n            {\r\n                ValidationOutput = \"\";\r\n                try\r\n                {\r\n                    // Read through the XML document to trigger validation\r\n                    while (reader.Read()) { }\r\n                }\r\n                catch (XmlException ex)\r\n                {\r\n                    ValidationOutput += ex.Message;\r\n                }\r\n            }\r\n        }";
            
            return content;

        }
    }
}
