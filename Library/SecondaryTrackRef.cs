﻿using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "secondaryTrack")]
public class SecondaryTrackRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string Ref {get;set;}
}
