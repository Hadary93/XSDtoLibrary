using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "propertiesArea")]
	public class PropertiesArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("teSpeedProfile", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSpeedProfile>? teSpeedProfiles;
		[XmlArray(Order=1)]
		[XmlArrayItem("trackEdgeGauge", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeGauge>? trackEdgeGauges;
		[XmlArray(Order=2)]
		[XmlArrayItem("trackEdgeLoadingGauge", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeLoadingGauge>? trackEdgeLoadingGauges;
		[XmlArray(Order=3)]
		[XmlArrayItem("trackCondition", Namespace = "https://erju.org/")]
		public List<infra.TrackCondition>? trackConditions;
		[XmlArray(Order=4)]
		[XmlArrayItem("currentLimitation", Namespace = "https://erju.org/")]
		public List<infra.CurrentLimitation>? currentLimitations;
		[XmlArray(Order=5)]
		[XmlArrayItem("permittedBrakingDistance", Namespace = "https://erju.org/")]
		public List<infra.PermittedBrakingDistance>? permittedBrakingDistances;
		[XmlArray(Order=6)]
		[XmlArrayItem("tractionSystem", Namespace = "https://erju.org/")]
		public List<infra.TractionSystem>? tractionSystems;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("versionTimestamp")]
		public string versionTimestamp {get;set;}
		[XmlAttribute("gauge")]
		public infra.TrackGaugeType gauge {get;set;}
		[XmlAttribute("loadingGaugeTypes")]
		public infra.LoadingGaugeType loadingGaugeTypes {get;set;}
		[XmlAttribute("defaultVoltage")]
		public infra.VoltageType defaultVoltage {get;set;}
		[XmlAttribute("defaultMaxCurrent")]
		public uint defaultMaxCurrent {get;set;}
	}
}