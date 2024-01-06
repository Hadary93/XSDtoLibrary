using System.Xml.Linq;

namespace Templates
{
    public class EnumTemplate
    {

        #region properties
        private const string usings = "using System.Xml.Serialization;";
        private string? NameSpace { get; set; }
        private string? ElementName { get; set; }
        private List<XElement> EnumValues { get; set; }
        #endregion

        #region constructor
        public EnumTemplate(List<XElement> enumValues, string nameSapce, string elementName)
        {
            EnumValues = enumValues;
            NameSpace = nameSapce;
            ElementName = elementName;

            var folderPath = $"{Helper.FindSolutionPath()}/Library/{Helper.GetNameSpaceLastName(nameSapce)}";
            var fileContent = CreateFileContent();
            var nameSpace = Helper.GetNameSpaceLastName(NameSpace);

            Helper.MakeFile(folderPath, fileContent, ElementName, nameSpace);
        }
        #endregion

        /// <summary>
        /// Create the file content as string.
        /// </summary>
        /// <returns></returns>
        private string CreateFileContent()
        {
            string content = $"{usings}\n";
            content += $"namespace {Helper.GetNameSpaceLastName(NameSpace)}\n";
            content += "{\n";
            content += $"\t[XmlRoot(Namespace = \"{NameSpace}\", ElementName = \"{Helper.LowerCase(ElementName)}\")]\n";
            content += $"\tpublic enum {ElementName}\n";
            content += "\t{\n";

            EnumValues.ToList().ForEach(x => { content += $"\t\t{x.Attribute("value")?.Value},\n"; });

            content += "\t}\n";
            content += "}";

            return content;
        }
    }
}
