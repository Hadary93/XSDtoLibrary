using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "speedLimitType")]
	public class SpeedLimitType
	{
		[XmlElement(Order=0)]		public OtherCategoryRef? otherCategory {get;set;}
		[XmlElement(Order=1)]		public CantDeficiencyRef? cantDeficiency {get;set;}
	}
}