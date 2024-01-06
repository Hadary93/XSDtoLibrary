using tp;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
public class Tp
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
	public void AllocationSection()
	{
		tp.AllocationSection allocationSection = new ();
		allocationSection.linearLocation = new(){ skipFromPathStart = 100 , skipFromPathEnd = 100 ,} ;
		allocationSection.id = "" ;
		allocationSection.name = "" ;
		var serializer = new XmlSerializer(typeof(AllocationSection));
		serializer.Serialize(writer, allocationSection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void DriveProtectionSection()
	{
		tp.DriveProtectionSection driveProtectionSection = new ();
		driveProtectionSection.trackEdgeSection = new(){ trackEdge = "" , skipFromPathStart = 100 , skipFromPathEnd = 100 ,} ;
		driveProtectionSection.id = "" ;
		driveProtectionSection.name = "" ;
		var serializer = new XmlSerializer(typeof(DriveProtectionSection));
		serializer.Serialize(writer, driveProtectionSection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void DriveProtectionSectionGroup()
	{
		tp.DriveProtectionSectionGroup driveProtectionSectionGroup = new ();
		driveProtectionSectionGroup.protectedInfraElements = new(){ simplePoint = new(){ Ref = "" ,} ,} ;
		driveProtectionSectionGroup.id = "" ;
		driveProtectionSectionGroup.name = "" ;
		driveProtectionSectionGroup.dependenciesType = new(){} ;
		driveProtectionSectionGroup.dependencies = 100 ;
		driveProtectionSectionGroup.runTime = 100 ;
		var serializer = new XmlSerializer(typeof(DriveProtectionSectionGroup));
		serializer.Serialize(writer, driveProtectionSectionGroup, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void FieldObjectController()
	{
		tp.FieldObjectController fieldObjectController = new ();
		fieldObjectController.controlledInfraElement = new(){ simplePoint = new(){ Ref = "" ,} ,} ;
		fieldObjectController.id = "" ;
		fieldObjectController.ipAddresses = "" ;
		var serializer = new XmlSerializer(typeof(FieldObjectController));
		serializer.Serialize(writer, fieldObjectController, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrainProtection()
	{
		tp.TrainProtection trainProtection = new ();
		var serializer = new XmlSerializer(typeof(TrainProtection));
		serializer.Serialize(writer, trainProtection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrainProtectionArea()
	{
		tp.TrainProtectionArea trainProtectionArea = new ();
		trainProtectionArea.id = "" ;
		var serializer = new XmlSerializer(typeof(TrainProtectionArea));
		serializer.Serialize(writer, trainProtectionArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
}