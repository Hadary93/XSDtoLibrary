using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "cantDeficiency")]
public class CantDeficiencyRef
{
	[XmlAttribute(AttributeName ="value")]
	public infra.CantDeficiencyCategory value {get;set;}
}
