using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "voltageType")]
	public enum VoltageType
	{
		vtNotFitted,
		vtAC25kv50Hz,
		vtAC15kv16_7Hz,
		vtDC3kv,
		vtDC1_5kv,
		vtDC600v,
		vtDC650v,
		vtDC750v,
		vtDC850v,
	}
}