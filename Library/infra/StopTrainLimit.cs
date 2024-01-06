using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimit")]
	public class StopTrainLimit
	{
		[XmlElement(Order=0)]
		public TrainMaxLengthRef? trainMaxLength {get;set;}
		[XmlElement(Order=1)]
		public TrainMaxAxlesRef? trainMaxAxles {get;set;}
		[XmlElement(Order=2)]
		public TrainMaxWagonsRef? trainMaxWagons {get;set;}
		[XmlElement(Order=3)]
		public TrainMaxSizeRef? trainMaxSize {get;set;}
	}
}