﻿using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "simplePoint")]
public class SimplePointRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}
