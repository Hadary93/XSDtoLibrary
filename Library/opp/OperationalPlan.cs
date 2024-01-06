using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "operationalPlan")]
	public class OperationalPlan
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("movement", Namespace = "https://erju.org/")]
		public List<opp.Movement>? movements;
		[XmlArray(Order=1)]
		[XmlArrayItem("restriction", Namespace = "https://erju.org/")]
		public List<opp.Restriction>? restrictions;
		[XmlArray(Order=2)]
		[XmlArrayItem("warningMeasure", Namespace = "https://erju.org/")]
		public List<opp.WarningMeasure>? warningMeasures;
	}
}