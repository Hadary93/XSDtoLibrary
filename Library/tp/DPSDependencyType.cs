﻿using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "dPSDependencyType")]
	public enum DPSDependencyType
	{
		Exclusive,
		Equivalent,
		Specific,
	}
}