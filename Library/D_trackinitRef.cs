﻿using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "d_trackinit")]
public class D_trackinitRef
{
	[XmlAttribute(AttributeName ="value")]
	public uint value {get;set;}
}
