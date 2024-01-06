using ss026;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
public class Ss026
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
	public void AxleLoad()
	{
		ss026.AxleLoad axleLoad = new ();
		axleLoad.d_axleload = 100 ;
		axleLoad.l_axleload = 100 ;
		axleLoad.q_front = true ;
		var serializer = new XmlSerializer(typeof(AxleLoad));
		serializer.Serialize(writer, axleLoad, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void AxleLoadDLRestriction()
	{
		ss026.AxleLoadDLRestriction axleLoadDLRestriction = new ();
		axleLoadDLRestriction.d_axleload_k = 100 ;
		axleLoadDLRestriction.l_axleload_k = 100 ;
		axleLoadDLRestriction.q_front_k = true ;
		var serializer = new XmlSerializer(typeof(AxleLoadDLRestriction));
		serializer.Serialize(writer, axleLoadDLRestriction, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void AxleLoadRestriction()
	{
		ss026.AxleLoadRestriction axleLoadRestriction = new ();
		axleLoadRestriction.m_axleloadcat_n = new(){} ;
		axleLoadRestriction.v_axleload_n = 100 ;
		var serializer = new XmlSerializer(typeof(AxleLoadRestriction));
		serializer.Serialize(writer, axleLoadRestriction, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void BalisePacket()
	{
		ss026.BalisePacket balisePacket = new ();
		balisePacket.packet = new(){ packet_0 = new(){ nid_vbcmk = 100 ,} ,} ;
		balisePacket.nid = 100 ;
		balisePacket.q_dir = new(){} ;
		var serializer = new XmlSerializer(typeof(BalisePacket));
		serializer.Serialize(writer, balisePacket, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void CountryBalise()
	{
		ss026.CountryBalise countryBalise = new ();
		countryBalise.q_newcountry_k = true ;
		countryBalise.nid_c_k = 100 ;
		countryBalise.nid_bg_k = 100 ;
		var serializer = new XmlSerializer(typeof(CountryBalise));
		serializer.Serialize(writer, countryBalise, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void CountryId()
	{
		ss026.CountryId countryId = new ();
		countryId.nid_c = 100 ;
		var serializer = new XmlSerializer(typeof(CountryId));
		serializer.Serialize(writer, countryId, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void DLMCondition()
	{
		ss026.DLMCondition dLMCondition = new ();
		dLMCondition.d_trackcond = 100 ;
		dLMCondition.l_trackcond = 100 ;
		dLMCondition.m_trackcond = new(){} ;
		var serializer = new XmlSerializer(typeof(DLMCondition));
		serializer.Serialize(writer, dLMCondition, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void DLTrackCond()
	{
		ss026.DLTrackCond dLTrackCond = new ();
		dLTrackCond.d_trackcond = 100 ;
		dLTrackCond.l_trackcond = 100 ;
		var serializer = new XmlSerializer(typeof(DLTrackCond));
		serializer.Serialize(writer, dLTrackCond, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_0()
	{
		ss026.ETCSPacket_0 eTCSPacket_0 = new ();
		eTCSPacket_0.nid_vbcmk = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_0));
		serializer.Serialize(writer, eTCSPacket_0, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_131()
	{
		ss026.ETCSPacket_131 eTCSPacket_131 = new ();
		eTCSPacket_131.d_rbctr = 100 ;
		eTCSPacket_131.nid_c = 100 ;
		eTCSPacket_131.nid_rbc = 100 ;
		eTCSPacket_131.nid_radio = 100 ;
		eTCSPacket_131.q_sleepsession = true ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_131));
		serializer.Serialize(writer, eTCSPacket_131, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_132()
	{
		ss026.ETCSPacket_132 eTCSPacket_132 = new ();
		eTCSPacket_132.q_aspect = true ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_132));
		serializer.Serialize(writer, eTCSPacket_132, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_133()
	{
		ss026.ETCSPacket_133 eTCSPacket_133 = new ();
		eTCSPacket_133.q_riu = true ;
		eTCSPacket_133.nid_c = 100 ;
		eTCSPacket_133.nid_riu = 100 ;
		eTCSPacket_133.nid_radio = 100 ;
		eTCSPacket_133.d_infill = 100 ;
		eTCSPacket_133.nid_bg = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_133));
		serializer.Serialize(writer, eTCSPacket_133, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_134()
	{
		ss026.ETCSPacket_134 eTCSPacket_134 = new ();
		eTCSPacket_134.nid_loop = 100 ;
		eTCSPacket_134.d_loop = 100 ;
		eTCSPacket_134.l_loop = 100 ;
		eTCSPacket_134.q_loopdir = true ;
		eTCSPacket_134.q_sscode = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_134));
		serializer.Serialize(writer, eTCSPacket_134, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_135()
	{
		ss026.ETCSPacket_135 eTCSPacket_135 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_135));
		serializer.Serialize(writer, eTCSPacket_135, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_136()
	{
		ss026.ETCSPacket_136 eTCSPacket_136 = new ();
		eTCSPacket_136.newCountry = new(){ nid_c = 100 ,} ;
		eTCSPacket_136.nid_bg = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_136));
		serializer.Serialize(writer, eTCSPacket_136, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_137()
	{
		ss026.ETCSPacket_137 eTCSPacket_137 = new ();
		eTCSPacket_137.q_srstop = true ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_137));
		serializer.Serialize(writer, eTCSPacket_137, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_138()
	{
		ss026.ETCSPacket_138 eTCSPacket_138 = new ();
		eTCSPacket_138.d_startreverse = 100 ;
		eTCSPacket_138.l_reversearea = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_138));
		serializer.Serialize(writer, eTCSPacket_138, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_139()
	{
		ss026.ETCSPacket_139 eTCSPacket_139 = new ();
		eTCSPacket_139.d_reverse = 100 ;
		eTCSPacket_139.v_reverse = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_139));
		serializer.Serialize(writer, eTCSPacket_139, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_141()
	{
		ss026.ETCSPacket_141 eTCSPacket_141 = new ();
		eTCSPacket_141.g_tsr = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_141));
		serializer.Serialize(writer, eTCSPacket_141, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_145()
	{
		ss026.ETCSPacket_145 eTCSPacket_145 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_145));
		serializer.Serialize(writer, eTCSPacket_145, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_16()
	{
		ss026.ETCSPacket_16 eTCSPacket_16 = new ();
		eTCSPacket_16.l_section = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_16));
		serializer.Serialize(writer, eTCSPacket_16, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_180()
	{
		ss026.ETCSPacket_180 eTCSPacket_180 = new ();
		eTCSPacket_180.q_lssma = true ;
		eTCSPacket_180.t_lssma = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_180));
		serializer.Serialize(writer, eTCSPacket_180, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_181()
	{
		ss026.ETCSPacket_181 eTCSPacket_181 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_181));
		serializer.Serialize(writer, eTCSPacket_181, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_2()
	{
		ss026.ETCSPacket_2 eTCSPacket_2 = new ();
		eTCSPacket_2.m_version = new(){} ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_2));
		serializer.Serialize(writer, eTCSPacket_2, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_254()
	{
		ss026.ETCSPacket_254 eTCSPacket_254 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_254));
		serializer.Serialize(writer, eTCSPacket_254, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_255()
	{
		ss026.ETCSPacket_255 eTCSPacket_255 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_255));
		serializer.Serialize(writer, eTCSPacket_255, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_3()
	{
		ss026.ETCSPacket_3 eTCSPacket_3 = new ();
		eTCSPacket_3.nkvItem = new(){ q_nvkint = true , q_nvkvintset = new(){} , a_nvp12 = 100 , a_nvp23 = 100 , v_nvkvint = 100 , m_nvkvint = 100.0 , m_nvkvint_2 = 100 , m_nvkrint = 100 ,} ;
		eTCSPacket_3.d_validnv = 100 ;
		eTCSPacket_3.nid_c = 100 ;
		eTCSPacket_3.nid_c_k = 100 ;
		eTCSPacket_3.v_nvshunt = 100 ;
		eTCSPacket_3.v_nvstff = 100 ;
		eTCSPacket_3.v_nvonsight = 100 ;
		eTCSPacket_3.v_nvlimsuperv = 100 ;
		eTCSPacket_3.v_nvunfit = 100 ;
		eTCSPacket_3.v_nvrel = 100 ;
		eTCSPacket_3.d_nvroll = 100 ;
		eTCSPacket_3.q_nvsbtsmperm = true ;
		eTCSPacket_3.q_nvemrrls = true ;
		eTCSPacket_3.q_nvguiperm = true ;
		eTCSPacket_3.q_nvsbfbperm = true ;
		eTCSPacket_3.q_nvinhsmicperm = true ;
		eTCSPacket_3.v_nvallowovtrp = 100 ;
		eTCSPacket_3.v_nvsupovtrp = 100 ;
		eTCSPacket_3.d_nvovtrp = 100 ;
		eTCSPacket_3.t_nvovtrp = 100 ;
		eTCSPacket_3.d_nvpotrp = 100 ;
		eTCSPacket_3.m_nvcontact = new(){} ;
		eTCSPacket_3.t_nvcontact = 100 ;
		eTCSPacket_3.m_nvderun = true ;
		eTCSPacket_3.d_nvstff = 100 ;
		eTCSPacket_3.q_nvdriver_adhes = true ;
		eTCSPacket_3.a_nvmaxredadh1 = 100 ;
		eTCSPacket_3.a_nvmaxredadh2 = 100 ;
		eTCSPacket_3.a_nvmaxredadh3 = 100 ;
		eTCSPacket_3.q_nvlocacc = 100 ;
		eTCSPacket_3.m_nvavadh = 100 ;
		eTCSPacket_3.m_nvebcl = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_3));
		serializer.Serialize(writer, eTCSPacket_3, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_39()
	{
		ss026.ETCSPacket_39 eTCSPacket_39 = new ();
		eTCSPacket_39.d_traction = 100 ;
		eTCSPacket_39.m_voltage = new(){} ;
		eTCSPacket_39.nid_ctraction = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_39));
		serializer.Serialize(writer, eTCSPacket_39, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_40()
	{
		ss026.ETCSPacket_40 eTCSPacket_40 = new ();
		eTCSPacket_40.d_current = 100 ;
		eTCSPacket_40.m_current = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_40));
		serializer.Serialize(writer, eTCSPacket_40, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_41()
	{
		ss026.ETCSPacket_41 eTCSPacket_41 = new ();
		eTCSPacket_41.d_leveltr = 100 ;
		eTCSPacket_41.m_leveltr = new(){} ;
		eTCSPacket_41.nid_ntc = 100 ;
		eTCSPacket_41.l_ackleveltr = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_41));
		serializer.Serialize(writer, eTCSPacket_41, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_42()
	{
		ss026.ETCSPacket_42 eTCSPacket_42 = new ();
		eTCSPacket_42.q_rbc = true ;
		eTCSPacket_42.nid_c = 100 ;
		eTCSPacket_42.nid_rbc = 100 ;
		eTCSPacket_42.nid_radio = 100 ;
		eTCSPacket_42.q_sleepsession = true ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_42));
		serializer.Serialize(writer, eTCSPacket_42, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_44()
	{
		ss026.ETCSPacket_44 eTCSPacket_44 = new ();
		eTCSPacket_44.nid_xuser = 100 ;
		eTCSPacket_44.nid_ntc = 100 ;
		eTCSPacket_44.otherData = "" ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_44));
		serializer.Serialize(writer, eTCSPacket_44, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_45()
	{
		ss026.ETCSPacket_45 eTCSPacket_45 = new ();
		eTCSPacket_45.nid_mn = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_45));
		serializer.Serialize(writer, eTCSPacket_45, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_46()
	{
		ss026.ETCSPacket_46 eTCSPacket_46 = new ();
		eTCSPacket_46.m_leveltr = new(){} ;
		eTCSPacket_46.nid_ntc = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_46));
		serializer.Serialize(writer, eTCSPacket_46, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_49()
	{
		ss026.ETCSPacket_49 eTCSPacket_49 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_49));
		serializer.Serialize(writer, eTCSPacket_49, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_5()
	{
		ss026.ETCSPacket_5 eTCSPacket_5 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_5));
		serializer.Serialize(writer, eTCSPacket_5, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_51()
	{
		ss026.ETCSPacket_51 eTCSPacket_51 = new ();
		eTCSPacket_51.axleLoadSelection = new(){ axleLoad = new(){ d_axleload = 100 , l_axleload = 100 , q_front = true ,} ,} ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_51));
		serializer.Serialize(writer, eTCSPacket_51, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_52()
	{
		ss026.ETCSPacket_52 eTCSPacket_52 = new ();
		eTCSPacket_52.pbdSelection = new(){ d_trackinit = new(){ value = 100 ,} ,} ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_52));
		serializer.Serialize(writer, eTCSPacket_52, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_6()
	{
		ss026.ETCSPacket_6 eTCSPacket_6 = new ();
		eTCSPacket_6.validityPeriod = new(){ t_vbc = 100 ,} ;
		eTCSPacket_6.nid_c = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_6));
		serializer.Serialize(writer, eTCSPacket_6, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_65()
	{
		ss026.ETCSPacket_65 eTCSPacket_65 = new ();
		eTCSPacket_65.nid_tsr = 100 ;
		eTCSPacket_65.d_tsr = 100 ;
		eTCSPacket_65.l_tsr = 100 ;
		eTCSPacket_65.q_front = true ;
		eTCSPacket_65.v_tsr = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_65));
		serializer.Serialize(writer, eTCSPacket_65, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_66()
	{
		ss026.ETCSPacket_66 eTCSPacket_66 = new ();
		eTCSPacket_66.nid_tsr = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_66));
		serializer.Serialize(writer, eTCSPacket_66, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_67()
	{
		ss026.ETCSPacket_67 eTCSPacket_67 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_67));
		serializer.Serialize(writer, eTCSPacket_67, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_68()
	{
		ss026.ETCSPacket_68 eTCSPacket_68 = new ();
		eTCSPacket_68.trackCondSelection = new(){ d_trackinit = new(){ value = 100 ,} ,} ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_68));
		serializer.Serialize(writer, eTCSPacket_68, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_69()
	{
		ss026.ETCSPacket_69 eTCSPacket_69 = new ();
		eTCSPacket_69.trackCondPlatformSelection = new(){ d_trackinit = new(){ value = 100 ,} ,} ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_69));
		serializer.Serialize(writer, eTCSPacket_69, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_71()
	{
		ss026.ETCSPacket_71 eTCSPacket_71 = new ();
		eTCSPacket_71.d_adhesion = 100 ;
		eTCSPacket_71.l_adhesion = 100 ;
		eTCSPacket_71.m_adhesion = true ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_71));
		serializer.Serialize(writer, eTCSPacket_71, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_72()
	{
		ss026.ETCSPacket_72 eTCSPacket_72 = new ();
		eTCSPacket_72.q_textclass = new(){} ;
		eTCSPacket_72.q_textdisplay = true ;
		eTCSPacket_72.d_textdisplay = 100 ;
		eTCSPacket_72.m_modetextdisplay = new(){} ;
		eTCSPacket_72.m_leveltextdisplay = new(){} ;
		eTCSPacket_72.nid_ntc = 100 ;
		eTCSPacket_72.l_textdisplay = 100 ;
		eTCSPacket_72.t_textdisplay = 100 ;
		eTCSPacket_72.q_textconfirm = new(){} ;
		eTCSPacket_72.q_conftextdisplay = true ;
		eTCSPacket_72.q_textreport = true ;
		eTCSPacket_72.nid_textmessage = 100 ;
		eTCSPacket_72.nid_c = 100 ;
		eTCSPacket_72.nid_rbc = 100 ;
		eTCSPacket_72.text = "" ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_72));
		serializer.Serialize(writer, eTCSPacket_72, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_76()
	{
		ss026.ETCSPacket_76 eTCSPacket_76 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_76));
		serializer.Serialize(writer, eTCSPacket_76, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_79()
	{
		ss026.ETCSPacket_79 eTCSPacket_79 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_79));
		serializer.Serialize(writer, eTCSPacket_79, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_80()
	{
		ss026.ETCSPacket_80 eTCSPacket_80 = new ();
		var serializer = new XmlSerializer(typeof(ETCSPacket_80));
		serializer.Serialize(writer, eTCSPacket_80, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_88()
	{
		ss026.ETCSPacket_88 eTCSPacket_88 = new ();
		eTCSPacket_88.lxStatus = new(){ v_lx = 100 , q_stoplx = true , l_stoplx = 100 ,} ;
		eTCSPacket_88.nid_lx = 100 ;
		eTCSPacket_88.d_lx = 100 ;
		eTCSPacket_88.l_lx = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_88));
		serializer.Serialize(writer, eTCSPacket_88, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ETCSPacket_90()
	{
		ss026.ETCSPacket_90 eTCSPacket_90 = new ();
		eTCSPacket_90.newCountry = new(){ nid_c = 100 ,} ;
		eTCSPacket_90.nid_bg = 100 ;
		var serializer = new XmlSerializer(typeof(ETCSPacket_90));
		serializer.Serialize(writer, eTCSPacket_90, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void GeoPosItem()
	{
		ss026.GeoPosItem geoPosItem = new ();
		geoPosItem.newCountry = new(){ nid_c = 100 ,} ;
		geoPosItem.nid_bg = 100 ;
		geoPosItem.d_posoff = 100 ;
		geoPosItem.q_mposition = true ;
		geoPosItem.m_position = 100 ;
		var serializer = new XmlSerializer(typeof(GeoPosItem));
		serializer.Serialize(writer, geoPosItem, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LevelTransition()
	{
		ss026.LevelTransition levelTransition = new ();
		levelTransition.m_leveltr = new(){} ;
		levelTransition.nid_ntc_k = 100 ;
		var serializer = new XmlSerializer(typeof(LevelTransition));
		serializer.Serialize(writer, levelTransition, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LevelTransitionWithAck()
	{
		ss026.LevelTransitionWithAck levelTransitionWithAck = new ();
		levelTransitionWithAck.m_leveltr = new(){} ;
		levelTransitionWithAck.nid_ntc_k = 100 ;
		levelTransitionWithAck.l_ackleveltr_k = 100 ;
		var serializer = new XmlSerializer(typeof(LevelTransitionWithAck));
		serializer.Serialize(writer, levelTransitionWithAck, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LinkItem()
	{
		ss026.LinkItem linkItem = new ();
		linkItem.q_newcountry = new(){ nid_c = 100 ,} ;
		linkItem.d_link = 100 ;
		linkItem.nid_bg = 100 ;
		linkItem.q_linkorientation = true ;
		linkItem.q_linkreaction = new(){} ;
		linkItem.q_locacc = 100 ;
		var serializer = new XmlSerializer(typeof(LinkItem));
		serializer.Serialize(writer, linkItem, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LMKVR()
	{
		ss026.LMKVR lMKVR = new ();
		lMKVR.l_nvkrint_l = 100 ;
		lMKVR.m_nvkrint_l = 100 ;
		var serializer = new XmlSerializer(typeof(LMKVR));
		serializer.Serialize(writer, lMKVR, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void LXStatus()
	{
		ss026.LXStatus lXStatus = new ();
		lXStatus.v_lx = 100 ;
		lXStatus.q_stoplx = true ;
		lXStatus.l_stoplx = 100 ;
		var serializer = new XmlSerializer(typeof(LXStatus));
		serializer.Serialize(writer, lXStatus, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ModeProfileItem()
	{
		ss026.ModeProfileItem modeProfileItem = new ();
		modeProfileItem.d_mamode = 100 ;
		modeProfileItem.m_mamode = new(){} ;
		modeProfileItem.v_mamode = 100 ;
		modeProfileItem.l_mamode = 100 ;
		modeProfileItem.l_ackmamode = 100 ;
		modeProfileItem.q_mamode = true ;
		var serializer = new XmlSerializer(typeof(ModeProfileItem));
		serializer.Serialize(writer, modeProfileItem, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void NewCountry()
	{
		ss026.NewCountry newCountry = new ();
		newCountry.nid_c = 100 ;
		var serializer = new XmlSerializer(typeof(NewCountry));
		serializer.Serialize(writer, newCountry, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void NKV()
	{
		ss026.NKV nKV = new ();
		nKV.q_nvkint = true ;
		nKV.q_nvkvintset = new(){} ;
		nKV.a_nvp12 = 100 ;
		nKV.a_nvp23 = 100 ;
		nKV.v_nvkvint = 100 ;
		nKV.m_nvkvint = 100.0 ;
		nKV.m_nvkvint_2 = 100 ;
		nKV.m_nvkrint = 100 ;
		var serializer = new XmlSerializer(typeof(NKV));
		serializer.Serialize(writer, nKV, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void NKVItem()
	{
		ss026.NKVItem nKVItem = new ();
		nKVItem.v_nvkvint = 100 ;
		nKVItem.m_nvkvint = 100 ;
		var serializer = new XmlSerializer(typeof(NKVItem));
		serializer.Serialize(writer, nKVItem, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void NKVSubItem()
	{
		ss026.NKVSubItem nKVSubItem = new ();
		nKVSubItem.nvp13 = new(){ a_nvp12 = 100 , a_nvp23 = 100 ,} ;
		var serializer = new XmlSerializer(typeof(NKVSubItem));
		serializer.Serialize(writer, nKVSubItem, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void NVP13()
	{
		ss026.NVP13 nVP13 = new ();
		nVP13.a_nvp12 = 100 ;
		nVP13.a_nvp23 = 100 ;
		var serializer = new XmlSerializer(typeof(NVP13));
		serializer.Serialize(writer, nVP13, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void Packet()
	{
		ss026.Packet packet = new ();
		packet.packet_0 = new(){ nid_vbcmk = 100 ,} ;
		var serializer = new XmlSerializer(typeof(Packet));
		serializer.Serialize(writer, packet, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void PermittedBrakingDist()
	{
		ss026.PermittedBrakingDist permittedBrakingDist = new ();
		permittedBrakingDist.d_pbd = 100 ;
		permittedBrakingDist.q_gdir = true ;
		permittedBrakingDist.g_pbdsr = 100 ;
		permittedBrakingDist.q_pbdsr = true ;
		permittedBrakingDist.d_pbdsr = 100 ;
		permittedBrakingDist.l_pbdsr = 100 ;
		var serializer = new XmlSerializer(typeof(PermittedBrakingDist));
		serializer.Serialize(writer, permittedBrakingDist, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TCSPCondition()
	{
		ss026.TCSPCondition tCSPCondition = new ();
		tCSPCondition.d_trackcond = 100 ;
		tCSPCondition.l_trackcond = 100 ;
		tCSPCondition.m_platform = new(){} ;
		tCSPCondition.q_platform = new(){} ;
		var serializer = new XmlSerializer(typeof(TCSPCondition));
		serializer.Serialize(writer, tCSPCondition, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void TractionSystem()
	{
		ss026.TractionSystem tractionSystem = new ();
		tractionSystem.d_voltage = new(){} ;
		tractionSystem.nid_ctraction = 100 ;
		var serializer = new XmlSerializer(typeof(TractionSystem));
		serializer.Serialize(writer, tractionSystem, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void ValidityPeriod()
	{
		ss026.ValidityPeriod validityPeriod = new ();
		validityPeriod.t_vbc = 100 ;
		var serializer = new XmlSerializer(typeof(ValidityPeriod));
		serializer.Serialize(writer, validityPeriod, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
	[Fact]
	public void VMM()
	{
		ss026.VMM vMM = new ();
		vMM.v_nvkvint_k_m = 100 ;
		vMM.m_nvkvint_k_m = 100 ;
		vMM.m_nvkvint_k_m_2 = 100 ;
		var serializer = new XmlSerializer(typeof(VMM));
		serializer.Serialize(writer, vMM, namespaces);
		string xml = writer.ToString();
		validate(xml);
		Assert.Equal("",ValidationOutput);
	}
}