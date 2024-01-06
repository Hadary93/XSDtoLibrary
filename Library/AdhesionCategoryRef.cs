using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "adhesionCategory")]
public class AdhesionCategoryRef
{
	[XmlAttribute(AttributeName ="value")]
	public opp.AdhesionCategory value {get;set;}
}
