using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "bufferStopAccuracy")]
	public class BufferStopAccuracy
	{
		[XmlAttribute("bufferStopId")]
		public string? bufferStopId {get;set;}
		[XmlAttribute("accuracy")]
		public uint accuracy {get;set;}
	}
}