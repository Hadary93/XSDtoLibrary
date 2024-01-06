using eng;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
public class Eng
{
	private string? ValidationOutput {get;set;}
	private StringWriter writer = new StringWriter();
	private XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        private void ValidationCallback(object? sender, System.Xml.Schema.ValidationEventArgs e)
        {
            
            if (e.Severity == XmlSeverityType.Warning)
            {
                ValidationOutput +=  e.Message;
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                ValidationOutput += e.Message;
            }
        }
        private void validate(string xml)
        {
            // Create an instance of XmlReaderSettings
            var settings = new XmlReaderSettings();

            // Enable XML schema validation
            settings.ValidationType = ValidationType.Schema;

            // Set the schema to validate against
		settings.Schemas.Add(null, "ato.xsd");
		settings.Schemas.Add(null, "eng.xsd");
		settings.Schemas.Add(null, "infra.xsd");
		settings.Schemas.Add(null, "map.xsd");
		settings.Schemas.Add(null, "opp.xsd");
		settings.Schemas.Add(null, "ss026.xsd");
		settings.Schemas.Add(null, "tp.xsd");
		// Attach the validation event handler
            settings.ValidationEventHandler += ValidationCallback;


            // Create an instance of XmlReader with the XML file and settings
            using (var reader = XmlReader.Create(new StringReader(xml), settings))
            {
                ValidationOutput = "";
                try
                {
                    // Read through the XML document to trigger validation
                    while (reader.Read()) { }
                }
                catch (XmlException ex)
                {
                    ValidationOutput += ex.Message;
                }
            }
        }
	[Fact]
	public void Balise()
	{
		eng.Balise balise = new ();
		balise.id = "" ;
		balise._fixed = true ;
		balise.q_updown = true ;
		balise.m_dup = new(){} ;
		balise.m_mcount = 100 ;
		balise.verticallyOriented = true ;
		balise.standardSize = true ;
		balise.sleeperFastening = "" ;
		balise.baliseMountingSystem = "" ;
		balise.designType = "" ;
		balise.locationReferenceMarker = "" ;
		var serializer = new XmlSerializer(typeof(Balise));
		serializer.Serialize(writer, balise, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void BaliseAccuracy()
	{
		eng.BaliseAccuracy baliseAccuracy = new ();
		baliseAccuracy.baliseId = "" ;
		baliseAccuracy.accuracy = 100 ;
		var serializer = new XmlSerializer(typeof(BaliseAccuracy));
		serializer.Serialize(writer, baliseAccuracy, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void BaliseGroup()
	{
		eng.BaliseGroup baliseGroup = new ();
		baliseGroup.id = "" ;
		baliseGroup.m_version = new(){} ;
		baliseGroup.q_link = true ;
		baliseGroup.telegram = "" ;
		baliseGroup.telegramChecksum = "" ;
		var serializer = new XmlSerializer(typeof(BaliseGroup));
		serializer.Serialize(writer, baliseGroup, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void BufferStop()
	{
		eng.BufferStop bufferStop = new ();
		bufferStop.id = "" ;
		bufferStop.bsType = new(){} ;
		var serializer = new XmlSerializer(typeof(BufferStop));
		serializer.Serialize(writer, bufferStop, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void BufferStopAccuracy()
	{
		eng.BufferStopAccuracy bufferStopAccuracy = new ();
		bufferStopAccuracy.bufferStopId = "" ;
		bufferStopAccuracy.accuracy = 100 ;
		var serializer = new XmlSerializer(typeof(BufferStopAccuracy));
		serializer.Serialize(writer, bufferStopAccuracy, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Crossing()
	{
		eng.Crossing crossing = new ();
		crossing.id = "" ;
		var serializer = new XmlSerializer(typeof(Crossing));
		serializer.Serialize(writer, crossing, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void DangerPoint()
	{
		eng.DangerPoint dangerPoint = new ();
		dangerPoint.id = "" ;
		dangerPoint.name = "" ;
		dangerPoint.trackEdge = "" ;
		dangerPoint.pos = 100 ;
		var serializer = new XmlSerializer(typeof(DangerPoint));
		serializer.Serialize(writer, dangerPoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void EngArea()
	{
		eng.EngArea engArea = new ();
		engArea.id = "" ;
		engArea.defaultSleepersType = new(){} ;
		var serializer = new XmlSerializer(typeof(EngArea));
		serializer.Serialize(writer, engArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSEngineering()
	{
		eng.ETCSEngineering eTCSEngineering = new ();
		var serializer = new XmlSerializer(typeof(ETCSEngineering));
		serializer.Serialize(writer, eTCSEngineering, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void EtcsMarkerAccuracy()
	{
		eng.EtcsMarkerAccuracy etcsMarkerAccuracy = new ();
		etcsMarkerAccuracy.markerId = "" ;
		etcsMarkerAccuracy.accuracy = 100 ;
		var serializer = new XmlSerializer(typeof(EtcsMarkerAccuracy));
		serializer.Serialize(writer, etcsMarkerAccuracy, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void FoulingPoint()
	{
		eng.FoulingPoint foulingPoint = new ();
		foulingPoint.id = "" ;
		foulingPoint.name = "" ;
		foulingPoint.trackEdge = "" ;
		foulingPoint.pos = 100 ;
		foulingPoint.clearancePoint = 100 ;
		var serializer = new XmlSerializer(typeof(FoulingPoint));
		serializer.Serialize(writer, foulingPoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LevelCrossing()
	{
		eng.LevelCrossing levelCrossing = new ();
		levelCrossing.id = "" ;
		var serializer = new XmlSerializer(typeof(LevelCrossing));
		serializer.Serialize(writer, levelCrossing, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LocationAccuracyArea()
	{
		eng.LocationAccuracyArea locationAccuracyArea = new ();
		locationAccuracyArea.id = "" ;
		var serializer = new XmlSerializer(typeof(LocationAccuracyArea));
		serializer.Serialize(writer, locationAccuracyArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void MileageArea()
	{
		eng.MileageArea mileageArea = new ();
		mileageArea.id = "" ;
		var serializer = new XmlSerializer(typeof(MileageArea));
		serializer.Serialize(writer, mileageArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void MileageLine()
	{
		eng.MileageLine mileageLine = new ();
		mileageLine.id = "" ;
		var serializer = new XmlSerializer(typeof(MileageLine));
		serializer.Serialize(writer, mileageLine, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void MileagePoint()
	{
		eng.MileagePoint mileagePoint = new ();
		mileagePoint.pos = 100.0 ;
		mileagePoint.mileage = 100.0 ;
		var serializer = new XmlSerializer(typeof(MileagePoint));
		serializer.Serialize(writer, mileagePoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void MileageReferenceMarker()
	{
		eng.MileageReferenceMarker mileageReferenceMarker = new ();
		mileageReferenceMarker.name = "" ;
		mileageReferenceMarker.mileage = 100.0 ;
		mileageReferenceMarker.trackEdge = "" ;
		mileageReferenceMarker.pos = 100.0 ;
		var serializer = new XmlSerializer(typeof(MileageReferenceMarker));
		serializer.Serialize(writer, mileageReferenceMarker, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void NationalBorderAccuracy()
	{
		eng.NationalBorderAccuracy nationalBorderAccuracy = new ();
		nationalBorderAccuracy.nationalBorderId = "" ;
		nationalBorderAccuracy.accuracy = 100 ;
		var serializer = new XmlSerializer(typeof(NationalBorderAccuracy));
		serializer.Serialize(writer, nationalBorderAccuracy, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SimplePoint()
	{
		eng.SimplePoint simplePoint = new ();
		simplePoint.id = "" ;
		simplePoint.tipShift = 100.0 ;
		simplePoint.bladeLength = 100.0 ;
		var serializer = new XmlSerializer(typeof(SimplePoint));
		serializer.Serialize(writer, simplePoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Sleepers()
	{
		eng.Sleepers sleepers = new ();
		sleepers.id = "" ;
		sleepers.type = new(){} ;
		var serializer = new XmlSerializer(typeof(Sleepers));
		serializer.Serialize(writer, sleepers, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void StopLocationAccuracy()
	{
		eng.StopLocationAccuracy stopLocationAccuracy = new ();
		stopLocationAccuracy.stopLocationId = "" ;
		stopLocationAccuracy.accuracy = 100 ;
		var serializer = new XmlSerializer(typeof(StopLocationAccuracy));
		serializer.Serialize(writer, stopLocationAccuracy, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeMileage()
	{
		eng.TrackEdgeMileage trackEdgeMileage = new ();
		trackEdgeMileage.id = "" ;
		var serializer = new XmlSerializer(typeof(TrackEdgeMileage));
		serializer.Serialize(writer, trackEdgeMileage, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
}