﻿using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "qDir")]
	public enum QDir
	{
		reverse,
		nominal,
		both,
		spare,
	}
}