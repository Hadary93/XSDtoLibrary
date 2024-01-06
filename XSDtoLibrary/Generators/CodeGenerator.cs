using System.Xml.Linq;
using Templates;

namespace Generators
{
    public class CodeGenerator
    {
        private string? targetNameSpace = string.Empty;
        public CodeGenerator(XElement xElement)
        {
            targetNameSpace = xElement.Attribute("targetNamespace")?.Value;

            var allElements = xElement.Elements();

            PrepareData(allElements);
        }

        private void PrepareData(IEnumerable<XElement> xElements)
        {
            
            var simpleTypes = SimpleTypes(xElements);
            var complexTypes = ComplexTypes(xElements);

            //create templates for enums and classes.
            simpleTypes.ToList().ForEach(x => { new EnumTemplate(GetEnumerations(x).ToList(), targetNameSpace ?? "", Helper.GetName(x) ?? "");});
            complexTypes.ToList().ForEach(x => { new ClassTemplate(x, targetNameSpace ?? "", Helper.GetName(x) ?? "");});
        }

        /// <summary>
        /// get all simple types of the root element which represent the Enums
        /// </summary>
        /// <param name="xElements"></param>
        /// <returns></returns>
        private IEnumerable<XElement> SimpleTypes(IEnumerable<XElement> xElements)
        {
            return xElements.Where(x => x.Name.LocalName.Equals("simpleType"))
                 .Select(x => x);
        }
        /// <summary>
        /// get all complex types of the root element which represent the classes
        /// </summary>
        /// <param name="xElements"></param>
        /// <returns></returns>
        private IEnumerable<XElement> ComplexTypes(IEnumerable<XElement> xElements)
        {
            return xElements.Where(x => x.Name.LocalName.Equals("complexType"))
                 .Select(x => x);
        }

        private IEnumerable<XElement> GetEnumerations(XElement xElement)
        {
            return xElement.Descendants().Where(x => x.Name.LocalName.Equals("enumeration"));
        }

    }
}
