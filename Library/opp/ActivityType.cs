using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "activityType")]
	public enum ActivityType
	{
		joinActivity,
		splitActivity,
		collectActivity,
		dropActivity,
		reverseActivity,
	}
}