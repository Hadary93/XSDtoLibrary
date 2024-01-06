using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "protectedInfraElement")]
	public class ProtectedInfraElement
	{
		[XmlElement(Order=0)]		public SimplePointRef? simplePoint {get;set;}
		[XmlElement(Order=1)]		public SlipCrossingRef? slipCrossing {get;set;}
		[XmlElement(Order=2)]		public CrossingRef? crossing {get;set;}
		[XmlElement(Order=3)]		public DerailerRef? derailer {get;set;}
		[XmlElement(Order=4)]		public LevelCrossingRef? levelCrossing {get;set;}
	}
}