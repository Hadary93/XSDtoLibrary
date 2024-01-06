using Generators;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using XSDtoLibrary.Generators;
using Templates;
class Program
{
    public static void Main()
    {
       // GenerateAllCode();

        
       GenerateAllTets();
    }

    private static void GenerateAllCode()
    {
        string? currentPath = Helper.FindSolutionPath();
        
        var allSchemas = Directory.GetFiles($"{currentPath}\\Data\\Schemas");

        foreach (var schema in allSchemas)
        {

            XmlReader xmlReader = XmlReader.Create(schema);
            XElement xElement = XElement.Load(xmlReader);
            CodeGenerator codeGenerator = new(xElement);

        }
    }

    private static void GenerateAllTets()
    {
        string? currentPath = Helper.FindSolutionPath();

        TestGenerator testGenerator = new($"{currentPath}/Library/bin/Debug/net6.0/Library.dll", $"{currentPath}\\Data\\Schemas");
    }
}