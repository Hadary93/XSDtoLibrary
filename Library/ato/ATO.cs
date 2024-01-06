using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTO")]
	public class ATO
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("atoArea", Namespace = "https://erju.org/")]
		public List<ato.ATOArea>? atoAreas;
	}
}