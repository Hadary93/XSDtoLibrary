﻿using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopLocation")]
public class StopLocationRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}
