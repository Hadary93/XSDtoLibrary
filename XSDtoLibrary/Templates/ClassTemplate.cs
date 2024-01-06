using System.Xml.Linq;

namespace Templates
{
    public class ClassTemplate : Helper
    {
        private const string usings = "using System.Xml.Serialization;";
        private IEnumerable<XElement> Children { get; set; }
        private string NameSpace { get; set; }
        private string ClassName { get; set; }
        public ClassTemplate(XElement Xelement, string nameSapce, string className)
        {
            Children = Xelement.Elements();
           
            NameSpace = nameSapce;
            ClassName = className;



            var folderPath = $"{Helper.FindSolutionPath()}/Library/{Helper.GetNameSpaceLastName(nameSapce)}";
            var fileContent = CreateFileContent();
            var nameSpace = Helper.GetNameSpaceLastName(NameSpace);

            MakeFile(folderPath, fileContent, ClassName, nameSpace);
        }

        private string CreateFileContent()
        {
            string content = $"{usings}\n";
            content += $"namespace {Helper.GetNameSpaceLastName(NameSpace)}\n";
            content += "{\n";
            content += $"\t[XmlRoot(Namespace = \"{NameSpace}\", ElementName = \"{Helper.LowerCase(ClassName)}\")]\n";
            content += $"\tpublic class {ClassName}\n";
            content += "\t{\n";

            for (int i = 0; i < this.Children.Count(); i++)
            {
                if (this.Children.ElementAt(i).Name.LocalName.Equals("attribute"))
                {
                    content += Attribute(this.Children.ElementAt(i));
                }
                else if (this.Children.ElementAt(i).Name.LocalName.Equals("sequence"))
                {
                    content += Sequence(this.Children.ElementAt(i));
                }
                else if (this.Children.ElementAt(i).Name.LocalName.Equals("choice"))
                {
                    content += Choice(this.Children.ElementAt(i));
                }
                else
                {
                    Console.WriteLine("elements type is not handled.");
                }
            }

            content += "\t}\n";
            content += "}";

            return content;
        }
        private string Attribute(XElement xElement)
        {

            var name = MapAttrName(GetName(xElement));
            var type = MapType(GetType(xElement));

            string content = $"\t\t[XmlAttribute(\"{GetName(xElement)}\")]\n";
            content += $"\t\tpublic {type} {name} {{get;set;}}\n";

            return content;
        }
        private string SingleElement(XElement xElement, int order)
        {
            string content = $"\t\t[XmlElement(Order={order})]"; ;

            var name = MapAttrName(GetName(xElement));
            var type = MapType(GetType(xElement));

            var innerAttribute = xElement.Descendants().Where(x => x.Name.LocalName.Equals("attribute")).Select(x => x).FirstOrDefault();

            if (innerAttribute == null)
            {

                content += $"\t\tpublic {type}? {name} {{get;set;}}\n";
            }
            else
            {
                var AttrName = innerAttribute?.Attribute("name")?.Value;
                var AttrType = innerAttribute?.Attribute("type")?.Value;

                content += $"\t\tpublic {UpperCase(name)}Ref? {name} {{get;set;}}\n";

                //content += InnerClass(name, AttrName, AttrType);

                AdditionalClassFile(xElement);
            }

            return content;
        }
        private string MultiElement(XElement xElement, int order)
        {

            var targetElement = xElement.Descendants().Where(x => x.Name.LocalName.Equals("element")).Select(x => x).First();
            var name = MapAttrName(GetName(xElement));
            var itemName = MapAttrName(GetName(targetElement));
            string? type = null;
            var reference = string.Empty;

            if (targetElement?.Attribute("maxOccurs") == null)
            {
                reference = "Ref?";

                AdditionalClassFile(targetElement);

                type = MapAttrName(UpperCase(GetName(targetElement)));
            }
            else
            {
                type = MapType(GetType(targetElement));
            }

            string content = $"\t\t[XmlArray(Order={order})]\n";
            content += $"\t\t[XmlArrayItem(\"{itemName}\", Namespace = \"https://erju.org/{this.targetNameSpace}\")]\n";
            content += $"\t\tpublic List<{type}{reference}>? {name};\n";

            return content;
        }
        private string Sequence(XElement sequenceElement)
        {
            string content = string.Empty;

            var elements = sequenceElement.Elements();

            for (int i = 0; i < elements.Count(); i++)
            {
                var containsElements = elements.ElementAt(i).Descendants().Where(x => x.Name.LocalName.Equals("element")).Select(x => x).FirstOrDefault();

                //this case is considered to be a list according to the given schema
                if (containsElements != null)
                {
                    content += MultiElement(elements.ElementAt(i), i);
                }
                else
                {
                    content += SingleElement(elements.ElementAt(i), i);
                }
            }
            return content;
        }
        private string Choice(XElement choiceElement)
        {
            string content = string.Empty;

            var elements = choiceElement.Elements();

            for (int i = 0; i < elements.Count(); i++)
            {

                var containsElements = elements.ElementAt(i).Descendants().Where(x => x.Name.LocalName.Equals("element")).Select(x => x).FirstOrDefault();

                //this case is considered to be a list according to the given schema
                if (containsElements != null)
                {
                    content += MultiElement(elements.ElementAt(i), i);
                }
                else
                {
                    content += SingleElement(elements.ElementAt(i), i);
                }
            }
            return content;
        }
        private void AdditionalClassFile(XElement? xElement)
        {

            var name = MapAttrName(GetName(xElement));

            var innerAttribute = xElement?.Descendants().Where(x => x.Name.LocalName.Equals("attribute")).Select(x => x).FirstOrDefault();

            var AttrName = innerAttribute?.Attribute("name")?.Value;
            var AttrType = innerAttribute?.Attribute("type")?.Value;

            string content = "using System.Xml.Serialization;\n";
            content += $"using System.Collections.Generic;\n";
            content += $"\n";
            content += $"[XmlRoot(Namespace = \"https://erju.org/infra\", ElementName = \"{LowerCase(name)}\")]\n";
            content += $"public class {UpperCase(name)}Ref\n";
            content += "{\n";

            content += $"\t[XmlAttribute(AttributeName =\"{AttrName}\")]\n";
            content += $"\tpublic {MapType(AttrType)} {MapAttrName(AttrName)} {{get;set;}}\n";

            content += "}\n";

            var folderPath = $"{Helper.FindSolutionPath()}/Library";

            MakeFile(folderPath, content, $"{UpperCase(name)}Ref", this.targetNameSpace);
        }

    }
}
