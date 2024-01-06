using map;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
public class Map
{
	private string ValidationOutput {get;set;}
	private StringWriter writer = new StringWriter();
	private XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        private void ValidationCallback(object sender, System.Xml.Schema.ValidationEventArgs e)
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
	public void FuncElementProjection()
	{
		map.FuncElementProjection funcElementProjection = new ();
		funcElementProjection.elementRef = new(){ simplePoint = new(){ Ref = "" ,} ,} ;
		funcElementProjection.x = 100.0 ;
		funcElementProjection.y = 100.0 ;
		funcElementProjection.z = 100.0 ;
		funcElementProjection.accX = 100.0 ;
		funcElementProjection.accY = 100.0 ;
		funcElementProjection.accZ = 100.0 ;
		var serializer = new XmlSerializer(typeof(FuncElementProjection));
		serializer.Serialize(writer, funcElementProjection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void MapArea()
	{
		map.MapArea mapArea = new ();
		mapArea.id = "" ;
		mapArea.name = "" ;
		mapArea.versionTimestamp = "2024-01-01" ;
		mapArea.areaId = "" ;
		mapArea.epsg = 100 ;
		var serializer = new XmlSerializer(typeof(MapArea));
		serializer.Serialize(writer, mapArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeCoordinate()
	{
		map.TrackEdgeCoordinate trackEdgeCoordinate = new ();
		trackEdgeCoordinate.pos = 100 ;
		trackEdgeCoordinate.x = 100.0 ;
		trackEdgeCoordinate.y = 100.0 ;
		trackEdgeCoordinate.z = 100.0 ;
		trackEdgeCoordinate.accPos = 100 ;
		trackEdgeCoordinate.accX = 100.0 ;
		trackEdgeCoordinate.accY = 100.0 ;
		trackEdgeCoordinate.accZ = 100.0 ;
		var serializer = new XmlSerializer(typeof(TrackEdgeCoordinate));
		serializer.Serialize(writer, trackEdgeCoordinate, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeProjection()
	{
		map.TrackEdgeProjection trackEdgeProjection = new ();
		trackEdgeProjection.id = "" ;
		var serializer = new XmlSerializer(typeof(TrackEdgeProjection));
		serializer.Serialize(writer, trackEdgeProjection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
}