using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "validityPeriod")]
	public class ValidityPeriod
	{
		[XmlAttribute("t_vbc")]
		public uint t_vbc {get;set;}
	}
}