using infra;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
public class Infra
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
	public void AtoArea()
	{
		infra.AtoArea atoArea = new ();
		atoArea.id = "" ;
		atoArea.versionTimestamp = "2024-01-01" ;
		var serializer = new XmlSerializer(typeof(AtoArea));
		serializer.Serialize(writer, atoArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void AxleLoadSpeedProfile()
	{
		infra.AxleLoadSpeedProfile axleLoadSpeedProfile = new ();
		axleLoadSpeedProfile.startPos = 100 ;
		axleLoadSpeedProfile.endPos = 100 ;
		axleLoadSpeedProfile.speed = 100 ;
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
		infra.Balise balise = new ();
		balise.id = "" ;
		balise.trackEdge = "" ;
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
		infra.BaliseGroup baliseGroup = new ();
		baliseGroup.id = "" ;
		baliseGroup.nidBG = 100 ;
		baliseGroup.nidC = 100 ;
		baliseGroup.bgFunction = new(){} ;
		var serializer = new XmlSerializer(typeof(BaliseGroup));
		serializer.Serialize(writer, baliseGroup, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Bridge()
	{
		infra.Bridge bridge = new ();
		bridge.id = "" ;
		bridge.name = "" ;
		var serializer = new XmlSerializer(typeof(Bridge));
		serializer.Serialize(writer, bridge, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void BufferStop()
	{
		infra.BufferStop bufferStop = new ();
		bufferStop.id = "" ;
		bufferStop.trackEdge = "" ;
		bufferStop.pos = 100 ;
		bufferStop.sameDir = true ;
		bufferStop.isSwitchable = true ;
		var serializer = new XmlSerializer(typeof(BufferStop));
		serializer.Serialize(writer, bufferStop, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void CantSamplePoint()
	{
		infra.CantSamplePoint cantSamplePoint = new ();
		cantSamplePoint.pos = 100 ;
		cantSamplePoint.appliedCant = 100.0 ;
		cantSamplePoint.cant = 100 ;
		var serializer = new XmlSerializer(typeof(CantSamplePoint));
		serializer.Serialize(writer, cantSamplePoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Crossing()
	{
		infra.Crossing crossing = new ();
		crossing.id = "" ;
		crossing.isSwitchable = true ;
		var serializer = new XmlSerializer(typeof(Crossing));
		serializer.Serialize(writer, crossing, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void CurrentLimitation()
	{
		infra.CurrentLimitation currentLimitation = new ();
		currentLimitation.maxCurrent = 100 ;
		var serializer = new XmlSerializer(typeof(CurrentLimitation));
		serializer.Serialize(writer, currentLimitation, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void CurveSamplePoint()
	{
		infra.CurveSamplePoint curveSamplePoint = new ();
		curveSamplePoint.pos = 100 ;
		curveSamplePoint.radius = 100 ;
		var serializer = new XmlSerializer(typeof(CurveSamplePoint));
		serializer.Serialize(writer, curveSamplePoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Derailer()
	{
		infra.Derailer derailer = new ();
		derailer.id = "" ;
		derailer.trackEdge = "" ;
		derailer.pos = 100 ;
		derailer.sameDir = true ;
		derailer.reversalTime = 100 ;
		derailer.derailToRight = true ;
		var serializer = new XmlSerializer(typeof(Derailer));
		serializer.Serialize(writer, derailer, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void DirTrackEdge()
	{
		infra.DirTrackEdge dirTrackEdge = new ();
		dirTrackEdge.trackEdge = "" ;
		dirTrackEdge.sameDir = true ;
		var serializer = new XmlSerializer(typeof(DirTrackEdge));
		serializer.Serialize(writer, dirTrackEdge, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void DirTrackEdgePoint()
	{
		infra.DirTrackEdgePoint dirTrackEdgePoint = new ();
		dirTrackEdgePoint.trackEdge = "" ;
		dirTrackEdgePoint.pos = 100 ;
		dirTrackEdgePoint.sameDir = true ;
		var serializer = new XmlSerializer(typeof(DirTrackEdgePoint));
		serializer.Serialize(writer, dirTrackEdgePoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void DirTrackEdgeSection()
	{
		infra.DirTrackEdgeSection dirTrackEdgeSection = new ();
		dirTrackEdgeSection.trackEdge = "" ;
		dirTrackEdgeSection.skipFromPathStart = 100 ;
		dirTrackEdgeSection.skipFromPathEnd = 100 ;
		dirTrackEdgeSection.direction = new(){} ;
		var serializer = new XmlSerializer(typeof(DirTrackEdgeSection));
		serializer.Serialize(writer, dirTrackEdgeSection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSMarker()
	{
		infra.ETCSMarker eTCSMarker = new ();
		eTCSMarker.id = "" ;
		eTCSMarker.trackEdge = "" ;
		eTCSMarker.pos = 100 ;
		eTCSMarker.sameDir = true ;
		eTCSMarker.markerFunctionStop = true ;
		var serializer = new XmlSerializer(typeof(ETCSMarker));
		serializer.Serialize(writer, eTCSMarker, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void FunctionalArea()
	{
		infra.FunctionalArea functionalArea = new ();
		functionalArea.id = "" ;
		functionalArea.versionTimestamp = "2024-01-01" ;
		var serializer = new XmlSerializer(typeof(FunctionalArea));
		serializer.Serialize(writer, functionalArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void GeometryArea()
	{
		infra.GeometryArea geometryArea = new ();
		geometryArea.id = "" ;
		geometryArea.versionTimestamp = "2024-01-01" ;
		geometryArea.alignment3d = true ;
		var serializer = new XmlSerializer(typeof(GeometryArea));
		serializer.Serialize(writer, geometryArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void HorizontalArc()
	{
		infra.HorizontalArc horizontalArc = new ();
		horizontalArc.pos = 100.0 ;
		horizontalArc.azimuth = 100.0 ;
		horizontalArc.radius = 100.0 ;
		var serializer = new XmlSerializer(typeof(HorizontalArc));
		serializer.Serialize(writer, horizontalArc, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void HorizontalLine()
	{
		infra.HorizontalLine horizontalLine = new ();
		horizontalLine.pos = 100.0 ;
		horizontalLine.azimuth = 100.0 ;
		var serializer = new XmlSerializer(typeof(HorizontalLine));
		serializer.Serialize(writer, horizontalLine, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void HorizontalSegment()
	{
		infra.HorizontalSegment horizontalSegment = new ();
		horizontalSegment.line = new(){ pos = 100.0 , azimuth = 100.0 ,} ;
		var serializer = new XmlSerializer(typeof(HorizontalSegment));
		serializer.Serialize(writer, horizontalSegment, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void HorizontalTransition()
	{
		infra.HorizontalTransition horizontalTransition = new ();
		horizontalTransition.pos = 100.0 ;
		horizontalTransition.azimuth = 100.0 ;
		horizontalTransition.radius = 100.0 ;
		horizontalTransition.type = new(){} ;
		var serializer = new XmlSerializer(typeof(HorizontalTransition));
		serializer.Serialize(writer, horizontalTransition, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Infrastructure()
	{
		infra.Infrastructure infrastructure = new ();
		var serializer = new XmlSerializer(typeof(Infrastructure));
		serializer.Serialize(writer, infrastructure, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LevelCrossing()
	{
		infra.LevelCrossing levelCrossing = new ();
		levelCrossing.id = "" ;
		var serializer = new XmlSerializer(typeof(LevelCrossing));
		serializer.Serialize(writer, levelCrossing, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LinkedPath()
	{
		infra.LinkedPath linkedPath = new ();
		linkedPath.skipFromPathStart = 100 ;
		linkedPath.skipFromPathEnd = 100 ;
		var serializer = new XmlSerializer(typeof(LinkedPath));
		serializer.Serialize(writer, linkedPath, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void NationalBorder()
	{
		infra.NationalBorder nationalBorder = new ();
		nationalBorder.id = "" ;
		nationalBorder.trackEdge = "" ;
		nationalBorder.pos = 100 ;
		nationalBorder.fromCountryCode = "" ;
		nationalBorder.toCountryCode = "" ;
		var serializer = new XmlSerializer(typeof(NationalBorder));
		serializer.Serialize(writer, nationalBorder, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void OperationalPoint()
	{
		infra.OperationalPoint operationalPoint = new ();
		operationalPoint.id = "" ;
		operationalPoint.name = "" ;
		operationalPoint.type = new(){} ;
		var serializer = new XmlSerializer(typeof(OperationalPoint));
		serializer.Serialize(writer, operationalPoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void PermittedBrakingDistance()
	{
		infra.PermittedBrakingDistance permittedBrakingDistance = new ();
		permittedBrakingDistance.pbdDist = 100 ;
		permittedBrakingDistance.brakeType = new(){} ;
		permittedBrakingDistance.pbdGradient = 100 ;
		permittedBrakingDistance.sameDir = true ;
		var serializer = new XmlSerializer(typeof(PermittedBrakingDistance));
		serializer.Serialize(writer, permittedBrakingDistance, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Platform()
	{
		infra.Platform platform = new ();
		platform.id = "" ;
		platform.name = "" ;
		var serializer = new XmlSerializer(typeof(Platform));
		serializer.Serialize(writer, platform, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void PlatformEdge()
	{
		infra.PlatformEdge platformEdge = new ();
		platformEdge.linearLocation = new(){ skipFromPathStart = 100 , skipFromPathEnd = 100 ,} ;
		platformEdge.id = "" ;
		platformEdge.name = "" ;
		platformEdge.height = new(){} ;
		var serializer = new XmlSerializer(typeof(PlatformEdge));
		serializer.Serialize(writer, platformEdge, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void PropertiesArea()
	{
		infra.PropertiesArea propertiesArea = new ();
		propertiesArea.id = "" ;
		propertiesArea.versionTimestamp = "2024-01-01" ;
		propertiesArea.gauge = new(){} ;
		propertiesArea.loadingGaugeTypes = new(){} ;
		propertiesArea.defaultVoltage = new(){} ;
		propertiesArea.defaultMaxCurrent = 100 ;
		var serializer = new XmlSerializer(typeof(PropertiesArea));
		serializer.Serialize(writer, propertiesArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SampledGeometryArea()
	{
		infra.SampledGeometryArea sampledGeometryArea = new ();
		sampledGeometryArea.id = "" ;
		sampledGeometryArea.versionTimestamp = "2024-01-01" ;
		var serializer = new XmlSerializer(typeof(SampledGeometryArea));
		serializer.Serialize(writer, sampledGeometryArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SampledTrackEdgeGeometry()
	{
		infra.SampledTrackEdgeGeometry sampledTrackEdgeGeometry = new ();
		sampledTrackEdgeGeometry.id = "" ;
		var serializer = new XmlSerializer(typeof(SampledTrackEdgeGeometry));
		serializer.Serialize(writer, sampledTrackEdgeGeometry, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SimplePoint()
	{
		infra.SimplePoint simplePoint = new ();
		simplePoint.id = "" ;
		simplePoint.reversalTime = 100 ;
		simplePoint.pointLeft = "" ;
		simplePoint.pointRight = "" ;
		var serializer = new XmlSerializer(typeof(SimplePoint));
		serializer.Serialize(writer, simplePoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SlipCrossing()
	{
		infra.SlipCrossing slipCrossing = new ();
		slipCrossing.id = "" ;
		slipCrossing.crossing = "" ;
		var serializer = new XmlSerializer(typeof(SlipCrossing));
		serializer.Serialize(writer, slipCrossing, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SlopeSamplePoint()
	{
		infra.SlopeSamplePoint slopeSamplePoint = new ();
		slopeSamplePoint.pos = 100 ;
		slopeSamplePoint.slope = 100 ;
		var serializer = new XmlSerializer(typeof(SlopeSamplePoint));
		serializer.Serialize(writer, slopeSamplePoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SpecificStaticSpeedLimit()
	{
		infra.SpecificStaticSpeedLimit specificStaticSpeedLimit = new ();
		specificStaticSpeedLimit.specificLimitType = new(){ otherCategory = new(){ value = new(){} ,} ,} ;
		specificStaticSpeedLimit.speed = 100 ;
		var serializer = new XmlSerializer(typeof(SpecificStaticSpeedLimit));
		serializer.Serialize(writer, specificStaticSpeedLimit, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SpeedProfile()
	{
		infra.SpeedProfile speedProfile = new ();
		var serializer = new XmlSerializer(typeof(SpeedProfile));
		serializer.Serialize(writer, speedProfile, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void StaticSpeedLimit()
	{
		infra.StaticSpeedLimit staticSpeedLimit = new ();
		staticSpeedLimit.pos = 100 ;
		staticSpeedLimit.speed = 100 ;
		var serializer = new XmlSerializer(typeof(StaticSpeedLimit));
		serializer.Serialize(writer, staticSpeedLimit, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void StopLocation()
	{
		infra.StopLocation stopLocation = new ();
		stopLocation.stopTrainLimit = new(){ trainMaxLength = new(){ value = 100 ,} ,} ;
		stopLocation.id = "" ;
		stopLocation.trackEdge = "" ;
		stopLocation.pos = 100 ;
		stopLocation.sameDir = true ;
		stopLocation.trainLoadType = new(){} ;
		stopLocation.doorOpeningSide = new(){} ;
		var serializer = new XmlSerializer(typeof(StopLocation));
		serializer.Serialize(writer, stopLocation, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TimingPoint()
	{
		infra.TimingPoint timingPoint = new ();
		timingPoint.activeObject = new(){ etcsMarker = new(){ Ref = "" ,} ,} ;
		timingPoint.id = "" ;
		timingPoint.trackEdge = "" ;
		timingPoint.pos = 100 ;
		var serializer = new XmlSerializer(typeof(TimingPoint));
		serializer.Serialize(writer, timingPoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TopoArea()
	{
		infra.TopoArea topoArea = new ();
		topoArea.id = "" ;
		topoArea.versionTimestamp = "2024-01-01" ;
		var serializer = new XmlSerializer(typeof(TopoArea));
		serializer.Serialize(writer, topoArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackCondition()
	{
		infra.TrackCondition trackCondition = new ();
		trackCondition.type = new(){} ;
		var serializer = new XmlSerializer(typeof(TrackCondition));
		serializer.Serialize(writer, trackCondition, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdge()
	{
		infra.TrackEdge trackEdge = new ();
		trackEdge.id = "" ;
		trackEdge.length = 100 ;
		var serializer = new XmlSerializer(typeof(TrackEdge));
		serializer.Serialize(writer, trackEdge, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeGauge()
	{
		infra.TrackEdgeGauge trackEdgeGauge = new ();
		trackEdgeGauge.gauge = new(){} ;
		var serializer = new XmlSerializer(typeof(TrackEdgeGauge));
		serializer.Serialize(writer, trackEdgeGauge, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeGeometry()
	{
		infra.TrackEdgeGeometry trackEdgeGeometry = new ();
		trackEdgeGeometry.id = "" ;
		var serializer = new XmlSerializer(typeof(TrackEdgeGeometry));
		serializer.Serialize(writer, trackEdgeGeometry, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeLink()
	{
		infra.TrackEdgeLink trackEdgeLink = new ();
		trackEdgeLink.id = "" ;
		trackEdgeLink.trackEdgeA = "" ;
		trackEdgeLink.trackEdgeB = "" ;
		trackEdgeLink.startOfA = true ;
		trackEdgeLink.startOfB = true ;
		var serializer = new XmlSerializer(typeof(TrackEdgeLink));
		serializer.Serialize(writer, trackEdgeLink, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeLoadingGauge()
	{
		infra.TrackEdgeLoadingGauge trackEdgeLoadingGauge = new ();
		trackEdgeLoadingGauge.loadingGaugeType = new(){} ;
		var serializer = new XmlSerializer(typeof(TrackEdgeLoadingGauge));
		serializer.Serialize(writer, trackEdgeLoadingGauge, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgePoint()
	{
		infra.TrackEdgePoint trackEdgePoint = new ();
		trackEdgePoint.trackEdge = "" ;
		trackEdgePoint.pos = 100 ;
		var serializer = new XmlSerializer(typeof(TrackEdgePoint));
		serializer.Serialize(writer, trackEdgePoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeSection()
	{
		infra.TrackEdgeSection trackEdgeSection = new ();
		trackEdgeSection.trackEdge = "" ;
		trackEdgeSection.skipFromPathStart = 100 ;
		trackEdgeSection.skipFromPathEnd = 100 ;
		var serializer = new XmlSerializer(typeof(TrackEdgeSection));
		serializer.Serialize(writer, trackEdgeSection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackEdgeSpeedProfile()
	{
		infra.TrackEdgeSpeedProfile trackEdgeSpeedProfile = new ();
		trackEdgeSpeedProfile.sameDirProfile = new(){} ;
		trackEdgeSpeedProfile.oppositeDirProfile = new(){} ;
		trackEdgeSpeedProfile.id = "" ;
		var serializer = new XmlSerializer(typeof(TrackEdgeSpeedProfile));
		serializer.Serialize(writer, trackEdgeSpeedProfile, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrackUsageArea()
	{
		infra.TrackUsageArea trackUsageArea = new ();
		trackUsageArea.id = "" ;
		trackUsageArea.versionTimestamp = "2024-01-01" ;
		var serializer = new XmlSerializer(typeof(TrackUsageArea));
		serializer.Serialize(writer, trackUsageArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TractionSystem()
	{
		infra.TractionSystem tractionSystem = new ();
		tractionSystem.type = new(){} ;
		var serializer = new XmlSerializer(typeof(TractionSystem));
		serializer.Serialize(writer, tractionSystem, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrainDetector()
	{
		infra.TrainDetector trainDetector = new ();
		trainDetector.id = "" ;
		trainDetector.trackEdge = "" ;
		trainDetector.pos = 100 ;
		trainDetector.type = new(){} ;
		trainDetector.sameDir = true ;
		var serializer = new XmlSerializer(typeof(TrainDetector));
		serializer.Serialize(writer, trainDetector, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TravelTimeMeasurementPoint()
	{
		infra.TravelTimeMeasurementPoint travelTimeMeasurementPoint = new ();
		travelTimeMeasurementPoint.id = "" ;
		travelTimeMeasurementPoint.trackEdge = "" ;
		travelTimeMeasurementPoint.pos = 100 ;
		var serializer = new XmlSerializer(typeof(TravelTimeMeasurementPoint));
		serializer.Serialize(writer, travelTimeMeasurementPoint, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Tunnel()
	{
		infra.Tunnel tunnel = new ();
		tunnel.id = "" ;
		tunnel.name = "" ;
		var serializer = new XmlSerializer(typeof(Tunnel));
		serializer.Serialize(writer, tunnel, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TunnelTube()
	{
		infra.TunnelTube tunnelTube = new ();
		tunnelTube.crossSection = 100 ;
		var serializer = new XmlSerializer(typeof(TunnelTube));
		serializer.Serialize(writer, tunnelTube, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TvpSection()
	{
		infra.TvpSection tvpSection = new ();
		tvpSection.id = "" ;
		tvpSection.name = "" ;
		var serializer = new XmlSerializer(typeof(TvpSection));
		serializer.Serialize(writer, tvpSection, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Underpass()
	{
		infra.Underpass underpass = new ();
		underpass.id = "" ;
		underpass.name = "" ;
		var serializer = new XmlSerializer(typeof(Underpass));
		serializer.Serialize(writer, underpass, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void VerticalArc()
	{
		infra.VerticalArc verticalArc = new ();
		verticalArc.pos = 100.0 ;
		verticalArc.slope = 100.0 ;
		verticalArc.radius = 100.0 ;
		var serializer = new XmlSerializer(typeof(VerticalArc));
		serializer.Serialize(writer, verticalArc, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void VerticalLine()
	{
		infra.VerticalLine verticalLine = new ();
		verticalLine.pos = 100.0 ;
		verticalLine.slope = 100.0 ;
		var serializer = new XmlSerializer(typeof(VerticalLine));
		serializer.Serialize(writer, verticalLine, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void VerticalSegment()
	{
		infra.VerticalSegment verticalSegment = new ();
		verticalSegment.line = new(){ pos = 100.0 , slope = 100.0 ,} ;
		var serializer = new XmlSerializer(typeof(VerticalSegment));
		serializer.Serialize(writer, verticalSegment, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
}