using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "driveProtectionSectionGroup")]
	public class DriveProtectionSectionGroup
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("driveProtectionSection", Namespace = "https://erju.org/")]
		public List<tp.DriveProtectionSection>? driveProtectionSections;
		[XmlElement(Order=1)]		public tp.ProtectedInfraElement? protectedInfraElements {get;set;}
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("name")]
		public string name {get;set;}
		[XmlAttribute("dependenciesType")]
		public tp.DPSDependencyType dependenciesType {get;set;}
		[XmlAttribute("dependencies")]
		public uint dependencies {get;set;}
		[XmlAttribute("runTime")]
		public uint runTime {get;set;}
	}
}