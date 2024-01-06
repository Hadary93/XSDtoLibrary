using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "alignmentType")]
	public enum AlignmentType
	{
		HEAD,
		CENTER,
		REAR,
	}
}