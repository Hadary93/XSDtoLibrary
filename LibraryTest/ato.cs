using ato;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
public class Ato
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
	public void ATO()
	{
		ato.ATO aTO = new ();
		var serializer = new XmlSerializer(typeof(ATO));
		serializer.Serialize(writer, aTO, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ATOArea()
	{
		ato.ATOArea aTOArea = new ();
		aTOArea.id = "" ;
		var serializer = new XmlSerializer(typeof(ATOArea));
		serializer.Serialize(writer, aTOArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ATOSegment()
	{
		ato.ATOSegment aTOSegment = new ();
		aTOSegment.trackSection = new(){ trackEdge = "" , skipFromPathStart = 100 , skipFromPathEnd = 100 ,} ;
		aTOSegment.segmentProfile = new(){ atotsContactInfo = new(){ nidATOTS = 100 , nidSP = 100 , spNidC = 100 , atotsNidC = 100 ,} , staticSpeedProfileStart = new(){ speed = 100 , trainEndApplicability = new(){} ,} , voltageStart = new(){ voltage = new(){} , nidC = 100 ,} , nidSP = 100 , length = 100 , version = 100 , nidC = 100 , eoaOffset = 100 , utcOffset = 100 , startAltitude = 100 , atotsContactInfoDir = true , gradientStart = 100 , curveStart = new(){} , currentStart = 100 ,} ;
		aTOSegment.id = 100 ;
		aTOSegment.sameDir = true ;
		var serializer = new XmlSerializer(typeof(ATOSegment));
		serializer.Serialize(writer, aTOSegment, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void AtoTSContactInfo()
	{
		ato.AtoTSContactInfo atoTSContactInfo = new ();
		atoTSContactInfo.nidATOTS = 100 ;
		atoTSContactInfo.nidSP = 100 ;
		atoTSContactInfo.spNidC = 100 ;
		atoTSContactInfo.atotsNidC = 100 ;
		var serializer = new XmlSerializer(typeof(AtoTSContactInfo));
		serializer.Serialize(writer, atoTSContactInfo, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void AxleLoadSpeedProfile()
	{
		ato.AxleLoadSpeedProfile axleLoadSpeedProfile = new ();
		axleLoadSpeedProfile.segmentSection = new(){ range = new(){} , pStart = 100 , pEnd = 100 ,} ;
		axleLoadSpeedProfile.speed = 100 ;
		axleLoadSpeedProfile.trainEndApplicability = new(){} ;
		axleLoadSpeedProfile.axleLoadCategory = new(){} ;
		var serializer = new XmlSerializer(typeof(AxleLoadSpeedProfile));
		serializer.Serialize(writer, axleLoadSpeedProfile, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Balise()
	{
		ato.Balise balise = new ();
		balise.positionInGroup = 100 ;
		balise.pos = 100 ;
		var serializer = new XmlSerializer(typeof(Balise));
		serializer.Serialize(writer, balise, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void BaliseGroup()
	{
		ato.BaliseGroup baliseGroup = new ();
		baliseGroup.nidBG = 100 ;
		baliseGroup.nidCQualifier = true ;
		baliseGroup.nidC = 100 ;
		var serializer = new XmlSerializer(typeof(BaliseGroup));
		serializer.Serialize(writer, baliseGroup, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void CurrentChange()
	{
		ato.CurrentChange currentChange = new ();
		currentChange.pos = 100 ;
		currentChange.current = 100 ;
		var serializer = new XmlSerializer(typeof(CurrentChange));
		serializer.Serialize(writer, currentChange, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void CurveChange()
	{
		ato.CurveChange curveChange = new ();
		curveChange.pos = 100 ;
		curveChange.curve = new(){} ;
		var serializer = new XmlSerializer(typeof(CurveChange));
		serializer.Serialize(writer, curveChange, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void GradientChange()
	{
		ato.GradientChange gradientChange = new ();
		gradientChange.pos = 100 ;
		gradientChange.gradient = 100 ;
		var serializer = new XmlSerializer(typeof(GradientChange));
		serializer.Serialize(writer, gradientChange, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LimitedDynamicBrakeForce()
	{
		ato.LimitedDynamicBrakeForce limitedDynamicBrakeForce = new ();
		limitedDynamicBrakeForce.segmentSection = new(){ range = new(){} , pStart = 100 , pEnd = 100 ,} ;
		limitedDynamicBrakeForce.dynamicBrakeForceLimit = 100 ;
		var serializer = new XmlSerializer(typeof(LimitedDynamicBrakeForce));
		serializer.Serialize(writer, limitedDynamicBrakeForce, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void PermittedBrakingDistance()
	{
		ato.PermittedBrakingDistance permittedBrakingDistance = new ();
		permittedBrakingDistance.segmentSection = new(){ range = new(){} , pStart = 100 , pEnd = 100 ,} ;
		permittedBrakingDistance.value = 100 ;
		permittedBrakingDistance.byEmergencyBrake = true ;
		permittedBrakingDistance.gradient = 100 ;
		var serializer = new XmlSerializer(typeof(PermittedBrakingDistance));
		serializer.Serialize(writer, permittedBrakingDistance, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SegmentProfile()
	{
		ato.SegmentProfile segmentProfile = new ();
		segmentProfile.atotsContactInfo = new(){ nidATOTS = 100 , nidSP = 100 , spNidC = 100 , atotsNidC = 100 ,} ;
		segmentProfile.staticSpeedProfileStart = new(){ speed = 100 , trainEndApplicability = new(){} ,} ;
		segmentProfile.voltageStart = new(){ voltage = new(){} , nidC = 100 ,} ;
		segmentProfile.nidSP = 100 ;
		segmentProfile.length = 100 ;
		segmentProfile.version = 100 ;
		segmentProfile.nidC = 100 ;
		segmentProfile.eoaOffset = 100 ;
		segmentProfile.utcOffset = 100 ;
		segmentProfile.startAltitude = 100 ;
		segmentProfile.atotsContactInfoDir = true ;
		segmentProfile.gradientStart = 100 ;
		segmentProfile.curveStart = new(){} ;
		segmentProfile.currentStart = 100 ;
		var serializer = new XmlSerializer(typeof(SegmentProfile));
		serializer.Serialize(writer, segmentProfile, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SegmentSection()
	{
		ato.SegmentSection segmentSection = new ();
		segmentSection.range = new(){} ;
		segmentSection.pStart = 100 ;
		segmentSection.pEnd = 100 ;
		var serializer = new XmlSerializer(typeof(SegmentSection));
		serializer.Serialize(writer, segmentSection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void StaticSpeedProfileChange()
	{
		ato.StaticSpeedProfileChange staticSpeedProfileChange = new ();
		staticSpeedProfileChange.pos = 100 ;
		staticSpeedProfileChange.speed = 100 ;
		staticSpeedProfileChange.trainEndApplicability = new(){} ;
		var serializer = new XmlSerializer(typeof(StaticSpeedProfileChange));
		serializer.Serialize(writer, staticSpeedProfileChange, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void StaticSpeedProfileStart()
	{
		ato.StaticSpeedProfileStart staticSpeedProfileStart = new ();
		staticSpeedProfileStart.speed = 100 ;
		staticSpeedProfileStart.trainEndApplicability = new(){} ;
		var serializer = new XmlSerializer(typeof(StaticSpeedProfileStart));
		serializer.Serialize(writer, staticSpeedProfileStart, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TimingPoint()
	{
		ato.TimingPoint timingPoint = new ();
		timingPoint.nidTP = 100 ;
		timingPoint.name = "" ;
		timingPoint.pos = 100 ;
		timingPoint.stopLocationTolerance = new(){} ;
		timingPoint.stoppingPointReachDistance = new(){} ;
		var serializer = new XmlSerializer(typeof(TimingPoint));
		serializer.Serialize(writer, timingPoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TimingPointMapping()
	{
		ato.TimingPointMapping timingPointMapping = new ();
		timingPointMapping.infraTimingPoint = "" ;
		timingPointMapping.atoTimingPoint = "" ;
		var serializer = new XmlSerializer(typeof(TimingPointMapping));
		serializer.Serialize(writer, timingPointMapping, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Tunnel()
	{
		ato.Tunnel tunnel = new ();
		tunnel.segmentSection = new(){ range = new(){} , pStart = 100 , pEnd = 100 ,} ;
		tunnel.type = new(){} ;
		var serializer = new XmlSerializer(typeof(Tunnel));
		serializer.Serialize(writer, tunnel, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void UnprotectedLX()
	{
		ato.UnprotectedLX unprotectedLX = new ();
		unprotectedLX.pNominal = 100 ;
		unprotectedLX.pReverse = 100 ;
		var serializer = new XmlSerializer(typeof(UnprotectedLX));
		serializer.Serialize(writer, unprotectedLX, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void VoltageChange()
	{
		ato.VoltageChange voltageChange = new ();
		voltageChange.pos = 100 ;
		voltageChange.voltage = new(){} ;
		voltageChange.nidC = 100 ;
		var serializer = new XmlSerializer(typeof(VoltageChange));
		serializer.Serialize(writer, voltageChange, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void VoltageStart()
	{
		ato.VoltageStart voltageStart = new ();
		voltageStart.voltage = new(){} ;
		voltageStart.nidC = 100 ;
		var serializer = new XmlSerializer(typeof(VoltageStart));
		serializer.Serialize(writer, voltageStart, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
}