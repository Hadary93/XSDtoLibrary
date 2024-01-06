using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Templates
{
    public class Helper
    {
        public string? targetNameSpace = string.Empty;
        public string? name = string.Empty;
        private static Dictionary<string, string> dataTypesMap = new() {
            {"xs:string","string?"},
            {"xs:unsignedInt","uint"},
            {"xs:boolean","bool"},
            {"xs:int","int"},
            {"xs:decimal","double"},
            {"xs:base64Binary","string?"},
            {"xs:date","string?"}
        };
        /// <summary>
        /// Create a file for this Template.
        /// </summary>
        /// <param name="fileContent"></param>
        /// <param name="fileName"></param>
        public static void MakeFile(string folderPath,string fileContent, string? fileName, string? nameSpace = null)
        {
            string? currentPath = Helper.FindSolutionPath();
            if (nameSpace != null && !Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (FileStream file = new($@"{folderPath}/{fileName}.cs", FileMode.Create))

            using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
            {
                writer.Write(fileContent);
            }

        }
        /// <summary>
        /// Map XSD types to C# types.
        /// </summary>
        /// <param name="xsdType"></param>
        /// <returns></returns>
        public static string? MapType(string? xsdType)
        {

            if (xsdType != null)
            {
                if (dataTypesMap.Keys.Contains(xsdType))
                {
                    dataTypesMap.TryGetValue(xsdType, out var type);
                    return type;
                }
                else if (xsdType.Contains("."))
                {
                    return $"{xsdType.Split(".")[1]}";
                }
                else if (!xsdType.Contains("xs:"))
                {
                    return $"{xsdType.Replace(':', '.')}";
                }
                else
                {
                    Console.WriteLine($"missing type :{xsdType}");
                    return null;
                }
            }
            else
            {
                Console.WriteLine($"null type");
                return null;
            }
        }
        /// <summary>
        /// function to change the reserved names by C# by including _ before it.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string? MapAttrName(string? name)
        {
            switch (name)
            {
                case "fixed":
                    return "_" + name;
                case "ref":
                    return "Ref";
                default:
                    break;
            }

            return name;
        }
        /// <summary>
        /// Lower first letter.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string LowerCase(string? text)
        {
            return text != null ? text.Substring(0, 1).ToLower() + text.Substring(1, text.Length - 1) : "";
        }
        /// <summary>
        /// Up first letter. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string UpperCase(string? text)
        {
            return text != null ? text.Substring(0, 1).ToUpper() + text.Substring(1, text.Length - 1) : "";
        }
        /// <summary>
        /// Get the Local Name of an element.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string? GetName(XElement? element)
        {
            if (element?.Attribute("name")!=null)
            {
                return element?.Attribute("name")?.Value;
            }
            else
            {
                throw new Exception();
            }
           
        }
        /// <summary>
        /// Get the Type of an element.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public string? GetType(XElement? element)
        {
            if (element?.Attribute("type") != null)
            {
                return element?.Attribute("type")?.Value;
            }
            else
            {
                Console.WriteLine("no type");
                return string.Empty;
            }
        }

        /// <summary>
        /// Get the namespace of lastname.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string? GetNameSpaceLastName(string? nameSpace)
        {
            return nameSpace?.Split("/")[^1];
        }


        public static string? FindSolutionPath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            FileInfo[] solutionFiles = directory.GetFiles("*.sln");

            if (solutionFiles.Length > 0)
            {
                // Assuming the first found .sln file is the one associated with the project
                return solutionFiles.First().FullName;
            }

            // If not found in current directory, check parent directories
            while (directory.Parent != null)
            {
                directory = directory.Parent;
                solutionFiles = directory.GetFiles("*.sln");

                if (solutionFiles.Length > 0)
                {
                    // Assuming the first found .sln file is the one associated with the project
                    return directory.FullName;
                }
            }

            return null;
        }
    }


}
