using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "otherCategory")]
public class OtherCategoryRef
{
	[XmlAttribute(AttributeName ="value")]
	public infra.OtherSpecificStaticSpeedProfileCategory value {get;set;}
}
