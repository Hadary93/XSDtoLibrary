using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "segmentProfile")]
	public class SegmentProfile
	{
		[XmlElement(Order=0)]		public ato.AtoTSContactInfo? atotsContactInfo {get;set;}
		[XmlElement(Order=1)]		public ato.StaticSpeedProfileStart? staticSpeedProfileStart {get;set;}
		[XmlArray(Order=2)]
		[XmlArrayItem("staticSpeedProfileChange", Namespace = "https://erju.org/")]
		public List<ato.StaticSpeedProfileChange>? staticSpeedProfileChanges;
		[XmlArray(Order=3)]
		[XmlArrayItem("gradientChange", Namespace = "https://erju.org/")]
		public List<ato.GradientChange>? gradientChanges;
		[XmlArray(Order=4)]
		[XmlArrayItem("curveChange", Namespace = "https://erju.org/")]
		public List<ato.CurveChange>? curveChanges;
		[XmlElement(Order=5)]		public ato.VoltageStart? voltageStart {get;set;}
		[XmlArray(Order=6)]
		[XmlArrayItem("voltageChange", Namespace = "https://erju.org/")]
		public List<ato.VoltageChange>? voltageChanges;
		[XmlArray(Order=7)]
		[XmlArrayItem("currentChange", Namespace = "https://erju.org/")]
		public List<ato.CurrentChange>? currentChanges;
		[XmlArray(Order=8)]
		[XmlArrayItem("baliseGroup", Namespace = "https://erju.org/")]
		public List<ato.BaliseGroup>? baliseGroups;
		[XmlArray(Order=9)]
		[XmlArrayItem("timingPoint", Namespace = "https://erju.org/")]
		public List<ato.TimingPoint>? timingPoints;
		[XmlArray(Order=10)]
		[XmlArrayItem("platformArea", Namespace = "https://erju.org/")]
		public List<ato.SegmentSection>? platformAreas;
		[XmlArray(Order=11)]
		[XmlArrayItem("tunnel", Namespace = "https://erju.org/")]
		public List<ato.Tunnel>? tunnels;
		[XmlArray(Order=12)]
		[XmlArrayItem("axleLoadSpeedProfile", Namespace = "https://erju.org/")]
		public List<ato.AxleLoadSpeedProfile>? axleLoadSpeedProfiles;
		[XmlArray(Order=13)]
		[XmlArrayItem("unprotectedLX", Namespace = "https://erju.org/")]
		public List<ato.UnprotectedLX>? unprotectedLXs;
		[XmlArray(Order=14)]
		[XmlArrayItem("permittedBrakingDistance", Namespace = "https://erju.org/")]
		public List<ato.PermittedBrakingDistance>? permittedBrakingDistances;
		[XmlArray(Order=15)]
		[XmlArrayItem("switchOffEddyCurrentBrakeServiceBrake", Namespace = "https://erju.org/")]
		public List<ato.SegmentSection>? switchOffEddyCurrentBrakeServiceBrakes;
		[XmlArray(Order=16)]
		[XmlArrayItem("switchOffEddyCurrentBrakeEmergencyBrake", Namespace = "https://erju.org/")]
		public List<ato.SegmentSection>? switchOffEddyCurrentBrakeEmergencyBrakes;
		[XmlArray(Order=17)]
		[XmlArrayItem("switchOffRegenerativeBrake", Namespace = "https://erju.org/")]
		public List<ato.SegmentSection>? switchOffRegenerativeBrakes;
		[XmlArray(Order=18)]
		[XmlArrayItem("switchOffMagneticShoeBrake", Namespace = "https://erju.org/")]
		public List<ato.SegmentSection>? switchOffMagneticShoeBrakes;
		[XmlArray(Order=19)]
		[XmlArrayItem("dynamicBrakeForceInhibition", Namespace = "https://erju.org/")]
		public List<ato.SegmentSection>? dynamicBrakeForceInhibitions;
		[XmlArray(Order=20)]
		[XmlArrayItem("limitedDynamicBrakeForce", Namespace = "https://erju.org/")]
		public List<ato.LimitedDynamicBrakeForce>? limitedDynamicBrakeForces;
		[XmlAttribute("nidSP")]
		public uint nidSP {get;set;}
		[XmlAttribute("length")]
		public uint length {get;set;}
		[XmlAttribute("version")]
		public uint version {get;set;}
		[XmlAttribute("nidC")]
		public uint nidC {get;set;}
		[XmlAttribute("eoaOffset")]
		public uint eoaOffset {get;set;}
		[XmlAttribute("utcOffset")]
		public uint utcOffset {get;set;}
		[XmlAttribute("startAltitude")]
		public int startAltitude {get;set;}
		[XmlAttribute("atotsContactInfoDir")]
		public bool atotsContactInfoDir {get;set;}
		[XmlAttribute("gradientStart")]
		public int gradientStart {get;set;}
		[XmlAttribute("curveStart")]
		public ato.CurveRadius curveStart {get;set;}
		[XmlAttribute("currentStart")]
		public uint currentStart {get;set;}
	}
}