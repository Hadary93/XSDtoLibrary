using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "infrastructure")]
	public class Infrastructure
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("topoArea", Namespace = "https://erju.org/")]
		public List<infra.TopoArea>? topoAreas;
		[XmlArray(Order=1)]
		[XmlArrayItem("geometryArea", Namespace = "https://erju.org/")]
		public List<infra.GeometryArea>? geometryAreas;
		[XmlArray(Order=2)]
		[XmlArrayItem("sampledGeometryArea", Namespace = "https://erju.org/")]
		public List<infra.SampledGeometryArea>? sampledGeometryAreas;
		[XmlArray(Order=3)]
		[XmlArrayItem("functionalArea", Namespace = "https://erju.org/")]
		public List<infra.FunctionalArea>? functionalAreas;
		[XmlArray(Order=4)]
		[XmlArrayItem("propertiesArea", Namespace = "https://erju.org/")]
		public List<infra.PropertiesArea>? propertiesAreas;
		[XmlArray(Order=5)]
		[XmlArrayItem("trackUsageArea", Namespace = "https://erju.org/")]
		public List<infra.TrackUsageArea>? trackUsageAreas;
		[XmlArray(Order=6)]
		[XmlArrayItem("atoArea", Namespace = "https://erju.org/")]
		public List<infra.AtoArea>? atoAreas;
	}
}