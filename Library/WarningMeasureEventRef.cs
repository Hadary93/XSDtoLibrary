﻿using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "warningMeasureEvent")]
public class WarningMeasureEventRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string Ref {get;set;}
}
