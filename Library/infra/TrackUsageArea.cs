using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackUsageArea")]
	public class TrackUsageArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("secondaryTrack", Namespace = "https://erju.org/")]
		public List<SecondaryTrackRef>? secondaryTracks;
		[XmlArray(Order=1)]
		[XmlArrayItem("shuntingTrack", Namespace = "https://erju.org/")]
		public List<ShuntingTrackRef>? shuntingTracks;
		[XmlArray(Order=2)]
		[XmlArrayItem("preferredSameDi", Namespace = "https://erju.org/")]
		public List<PreferredSameDiRef>? preferredSameDir;
		[XmlArray(Order=3)]
		[XmlArrayItem("preferredOppositeDi", Namespace = "https://erju.org/")]
		public List<PreferredOppositeDiRef>? preferredOppositeDir;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("versionTimestamp")]
		public string? versionTimestamp {get;set;}
	}
}