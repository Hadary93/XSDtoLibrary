using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "gradeOfAutomation")]
	public enum GradeOfAutomation
	{
		GoA_Unknown,
		GoA1,
		GoA2,
		GoA3,
		GoA4,
	}
}