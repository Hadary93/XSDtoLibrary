using opp;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
public class Opp
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
	public void AnyClass()
	{
		opp.AnyClass anyClass = new ();
		anyClass.className = "" ;
		anyClass.content = "" ;
		var serializer = new XmlSerializer(typeof(AnyClass));
		serializer.Serialize(writer, anyClass, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Movement()
	{
		opp.Movement movement = new ();
		movement.id = "" ;
		movement.issuedAt = "2024-01-01" ;
		movement.domainDataVersionRef = "" ;
		var serializer = new XmlSerializer(typeof(Movement));
		serializer.Serialize(writer, movement, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void MovementEvent()
	{
		opp.MovementEvent movementEvent = new ();
		movementEvent.position = new(){ trackEdge = "" , pos = 100 , sameDir = true ,} ;
		movementEvent.trackPathToNextEvent = new(){ skipFromPathStart = 100 , skipFromPathEnd = 100 ,} ;
		movementEvent.stopDescription = new(){ stopTimes = new(){ minStopTime = 100 , operationalReserve = 100 , additionalReserve = 100 ,} , stopType = new(){} , stopSkipped = true , openingDoorSide = new(){} , centralisedOpening = true , centralisedClosing = true , changeOfGradeOfAutomation = true , relaxedCoupler = true , holdTrain = true ,} ;
		movementEvent.id = "" ;
		movementEvent.type = new(){} ;
		movementEvent.alignment = new(){} ;
		var serializer = new XmlSerializer(typeof(MovementEvent));
		serializer.Serialize(writer, movementEvent, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void MovementEventTime()
	{
		opp.MovementEventTime movementEventTime = new ();
		movementEventTime.type = new(){} ;
		movementEventTime.dateTime = "2024-01-01" ;
		var serializer = new XmlSerializer(typeof(MovementEventTime));
		serializer.Serialize(writer, movementEventTime, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void MovementRestriction()
	{
		opp.MovementRestriction movementRestriction = new ();
		movementRestriction.startPoint = new(){ trackEdge = "" , pos = 100 , sameDir = true ,} ;
		movementRestriction.endPoint = new(){ trackEdge = "" , pos = 100 , sameDir = true ,} ;
		movementRestriction.specificRestriction = new(){ maxSpeed = new(){ value = 100 ,} ,} ;
		var serializer = new XmlSerializer(typeof(MovementRestriction));
		serializer.Serialize(writer, movementRestriction, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void OperationalConsist()
	{
		opp.OperationalConsist operationalConsist = new ();
		operationalConsist.supportedOnBoardEquipment = new(){ type = new(){} , etcsVersions = "" ,} ;
		operationalConsist.Ref = "" ;
		var serializer = new XmlSerializer(typeof(OperationalConsist));
		serializer.Serialize(writer, operationalConsist, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void OperationalPlan()
	{
		opp.OperationalPlan operationalPlan = new ();
		var serializer = new XmlSerializer(typeof(OperationalPlan));
		serializer.Serialize(writer, operationalPlan, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void OperationalTrainCategory()
	{
		opp.OperationalTrainCategory operationalTrainCategory = new ();
		operationalTrainCategory.type = new(){} ;
		operationalTrainCategory.description = "" ;
		operationalTrainCategory.trainUsage = new(){} ;
		var serializer = new XmlSerializer(typeof(OperationalTrainCategory));
		serializer.Serialize(writer, operationalTrainCategory, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void PassengerTransferActivity()
	{
		opp.PassengerTransferActivity passengerTransferActivity = new ();
		passengerTransferActivity.waitingForEvent = "" ;
		passengerTransferActivity.transferDuration = 100 ;
		var serializer = new XmlSerializer(typeof(PassengerTransferActivity));
		serializer.Serialize(writer, passengerTransferActivity, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void PhysicalTrainUnitIdentifier()
	{
		opp.PhysicalTrainUnitIdentifier physicalTrainUnitIdentifier = new ();
		physicalTrainUnitIdentifier.trainRunningNumber = "" ;
		physicalTrainUnitIdentifier.additionalTrainRunningNumber = "" ;
		physicalTrainUnitIdentifier.tafTapTsiTrainID = "" ;
		physicalTrainUnitIdentifier.leadingOnBoardUnitId = "" ;
		var serializer = new XmlSerializer(typeof(PhysicalTrainUnitIdentifier));
		serializer.Serialize(writer, physicalTrainUnitIdentifier, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void RestrictedAspects()
	{
		opp.RestrictedAspects restrictedAspects = new ();
		restrictedAspects.temporarySpeedRestriction = 100 ;
		restrictedAspects.allowedDrivingModes = new(){} ;
		restrictedAspects.nonStoppingArea = true ;
		restrictedAspects.operationalRadioHole = true ;
		restrictedAspects.maxAdhesion = new(){} ;
		var serializer = new XmlSerializer(typeof(RestrictedAspects));
		serializer.Serialize(writer, restrictedAspects, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Restriction()
	{
		opp.Restriction restriction = new ();
		restriction.id = "" ;
		restriction.activationTime = "2024-01-01" ;
		restriction.removalTime = "2024-01-01" ;
		var serializer = new XmlSerializer(typeof(Restriction));
		serializer.Serialize(writer, restriction, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void RestrictionArea()
	{
		opp.RestrictionArea restrictionArea = new ();
		var serializer = new XmlSerializer(typeof(RestrictionArea));
		serializer.Serialize(writer, restrictionArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void RestrictionEvent()
	{
		opp.RestrictionEvent restrictionEvent = new ();
		restrictionEvent.id = "" ;
		restrictionEvent.restrictions = "" ;
		restrictionEvent.start = true ;
		restrictionEvent.alignment = new(){} ;
		var serializer = new XmlSerializer(typeof(RestrictionEvent));
		serializer.Serialize(writer, restrictionEvent, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SpecificRestriction()
	{
		opp.SpecificRestriction specificRestriction = new ();
		specificRestriction.appliedToTrips = new(){ trainTypes = new(){} , engineeringTrainsOnly = true , maxAxleLoad = 100 , minCantDeficiency = new(){} , trainCategories = new(){} , tractionTypes = new(){} , prohibitedLoadingGaugeTypes = new(){} , prohibitedLoadingType = new(){} , minTrainAirTightness = new(){} ,} ;
		specificRestriction.restrictedAspects = new(){ temporarySpeedRestriction = 100 , allowedDrivingModes = new(){} , nonStoppingArea = true , operationalRadioHole = true , maxAdhesion = new(){} ,} ;
		var serializer = new XmlSerializer(typeof(SpecificRestriction));
		serializer.Serialize(writer, specificRestriction, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void StopDescription()
	{
		opp.StopDescription stopDescription = new ();
		stopDescription.stopTimes = new(){ minStopTime = 100 , operationalReserve = 100 , additionalReserve = 100 ,} ;
		stopDescription.stopType = new(){} ;
		stopDescription.stopSkipped = true ;
		stopDescription.openingDoorSide = new(){} ;
		stopDescription.centralisedOpening = true ;
		stopDescription.centralisedClosing = true ;
		stopDescription.changeOfGradeOfAutomation = true ;
		stopDescription.relaxedCoupler = true ;
		stopDescription.holdTrain = true ;
		var serializer = new XmlSerializer(typeof(StopDescription));
		serializer.Serialize(writer, stopDescription, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void StopTimes()
	{
		opp.StopTimes stopTimes = new ();
		stopTimes.minStopTime = 100 ;
		stopTimes.operationalReserve = 100 ;
		stopTimes.additionalReserve = 100 ;
		var serializer = new XmlSerializer(typeof(StopTimes));
		serializer.Serialize(writer, stopTimes, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void SupportedOnBoardEquipment()
	{
		opp.SupportedOnBoardEquipment supportedOnBoardEquipment = new ();
		supportedOnBoardEquipment.type = new(){} ;
		supportedOnBoardEquipment.etcsVersions = "" ;
		var serializer = new XmlSerializer(typeof(SupportedOnBoardEquipment));
		serializer.Serialize(writer, supportedOnBoardEquipment, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrainGroupSpec()
	{
		opp.TrainGroupSpec trainGroupSpec = new ();
		trainGroupSpec.trainTypes = new(){} ;
		trainGroupSpec.engineeringTrainsOnly = true ;
		trainGroupSpec.maxAxleLoad = 100 ;
		trainGroupSpec.minCantDeficiency = new(){} ;
		trainGroupSpec.trainCategories = new(){} ;
		trainGroupSpec.tractionTypes = new(){} ;
		trainGroupSpec.prohibitedLoadingGaugeTypes = new(){} ;
		trainGroupSpec.prohibitedLoadingType = new(){} ;
		trainGroupSpec.minTrainAirTightness = new(){} ;
		var serializer = new XmlSerializer(typeof(TrainGroupSpec));
		serializer.Serialize(writer, trainGroupSpec, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrainUnit()
	{
		opp.TrainUnit trainUnit = new ();
		trainUnit.physicalTrainUnit = new(){ trainRunningNumber = "" , additionalTrainRunningNumber = "" , tafTapTsiTrainID = "" , leadingOnBoardUnitId = "" ,} ;
		trainUnit.operationalTrainCategory = new(){ type = new(){} , description = "" , trainUsage = new(){} ,} ;
		trainUnit.nominalRotatingMass = 100 ;
		trainUnit.regularBrakeWeightPercentage = 100 ;
		trainUnit.emergencyBrakeWeightPercentage = 100 ;
		trainUnit.brakePosition = new(){} ;
		trainUnit.brakeModelType = new(){} ;
		trainUnit.usedGradeOfAutomation = new(){} ;
		var serializer = new XmlSerializer(typeof(TrainUnit));
		serializer.Serialize(writer, trainUnit, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TrainUnitActivity()
	{
		opp.TrainUnitActivity trainUnitActivity = new ();
		trainUnitActivity.type = new(){} ;
		trainUnitActivity.actualTrainUnitIndex = 100 ;
		trainUnitActivity.targetTrainUnitIndex = 100 ;
		var serializer = new XmlSerializer(typeof(TrainUnitActivity));
		serializer.Serialize(writer, trainUnitActivity, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void WarningArea()
	{
		opp.WarningArea warningArea = new ();
		warningArea.id = "" ;
		warningArea.activationTime = "2024-01-01" ;
		warningArea.removalTime = "2024-01-01" ;
		var serializer = new XmlSerializer(typeof(WarningArea));
		serializer.Serialize(writer, warningArea, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void WarningDevice()
	{
		opp.WarningDevice warningDevice = new ();
		warningDevice.id = "" ;
		warningDevice.type = new(){} ;
		var serializer = new XmlSerializer(typeof(WarningDevice));
		serializer.Serialize(writer, warningDevice, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void WarningMeasure()
	{
		opp.WarningMeasure warningMeasure = new ();
		warningMeasure.id = "" ;
		var serializer = new XmlSerializer(typeof(WarningMeasure));
		serializer.Serialize(writer, warningMeasure, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void WarningMeasureEvent()
	{
		opp.WarningMeasureEvent warningMeasureEvent = new ();
		warningMeasureEvent.id = "" ;
		warningMeasureEvent.warningArea = "" ;
		warningMeasureEvent.activation = true ;
		warningMeasureEvent.alignment = new(){} ;
		var serializer = new XmlSerializer(typeof(WarningMeasureEvent));
		serializer.Serialize(writer, warningMeasureEvent, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
}