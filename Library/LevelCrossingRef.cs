﻿using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "levelCrossing")]
public class LevelCrossingRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string Ref {get;set;}
}
