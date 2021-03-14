namespace XMLJSON
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class studentiPredmetu
    {
        private studentiPredmetuStudentPredmetu[] studentPredmetuField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("studentPredmetu")]
        public studentiPredmetuStudentPredmetu[] studentPredmetu
        {
            get { return this.studentPredmetuField; }
            set { this.studentPredmetuField = value; }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class studentiPredmetuStudentPredmetu
    {
        private string osCisloField;

        private string jmenoField;

        private string prijmeniField;

        private string stavField;

        private string userNameField;

        private ushort stprIdnoField;

        private string nazevSpField;

        private string fakultaSpField;

        private string kodSpField;

        private string formaSpField;

        private string typSpField;

        private byte typSpKeyField;

        private string mistoVyukyField;

        private byte rocnikField;

        private byte financovaniField;

        private string oborKombField;

        private string oborIdnosField;

        private string emailField;

        private string cisloKartyField;

        private string pohlaviField;

        private string evidovanBankovniUcetField;

        private string statutPredmetuField;

        private string[] textField;

        /// <remarks/>
        public string osCislo
        {
            get { return this.osCisloField; }
            set { this.osCisloField = value; }
        }

        /// <remarks/>
        public string jmeno
        {
            get { return this.jmenoField; }
            set { this.jmenoField = value; }
        }

        /// <remarks/>
        public string prijmeni
        {
            get { return this.prijmeniField; }
            set { this.prijmeniField = value; }
        }

        /// <remarks/>
        public string stav
        {
            get { return this.stavField; }
            set { this.stavField = value; }
        }

        /// <remarks/>
        public string userName
        {
            get { return this.userNameField; }
            set { this.userNameField = value; }
        }

        /// <remarks/>
        public ushort stprIdno
        {
            get { return this.stprIdnoField; }
            set { this.stprIdnoField = value; }
        }

        /// <remarks/>
        public string nazevSp
        {
            get { return this.nazevSpField; }
            set { this.nazevSpField = value; }
        }

        /// <remarks/>
        public string fakultaSp
        {
            get { return this.fakultaSpField; }
            set { this.fakultaSpField = value; }
        }

        /// <remarks/>
        public string kodSp
        {
            get { return this.kodSpField; }
            set { this.kodSpField = value; }
        }

        /// <remarks/>
        public string formaSp
        {
            get { return this.formaSpField; }
            set { this.formaSpField = value; }
        }

        /// <remarks/>
        public string typSp
        {
            get { return this.typSpField; }
            set { this.typSpField = value; }
        }

        /// <remarks/>
        public byte typSpKey
        {
            get { return this.typSpKeyField; }
            set { this.typSpKeyField = value; }
        }

        /// <remarks/>
        public string mistoVyuky
        {
            get { return this.mistoVyukyField; }
            set { this.mistoVyukyField = value; }
        }

        /// <remarks/>
        public byte rocnik
        {
            get { return this.rocnikField; }
            set { this.rocnikField = value; }
        }

        /// <remarks/>
        public byte financovani
        {
            get { return this.financovaniField; }
            set { this.financovaniField = value; }
        }

        /// <remarks/>
        public string oborKomb
        {
            get { return this.oborKombField; }
            set { this.oborKombField = value; }
        }

        /// <remarks/>
        public string oborIdnos
        {
            get { return this.oborIdnosField; }
            set { this.oborIdnosField = value; }
        }

        /// <remarks/>
        public string email
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }

        /// <remarks/>
        public string cisloKarty
        {
            get { return this.cisloKartyField; }
            set { this.cisloKartyField = value; }
        }

        /// <remarks/>
        public string pohlavi
        {
            get { return this.pohlaviField; }
            set { this.pohlaviField = value; }
        }

        /// <remarks/>
        public string evidovanBankovniUcet
        {
            get { return this.evidovanBankovniUcetField; }
            set { this.evidovanBankovniUcetField = value; }
        }

        /// <remarks/>
        public string statutPredmetu
        {
            get { return this.statutPredmetuField; }
            set { this.statutPredmetuField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get { return this.textField; }
            set { this.textField = value; }
        }
    }
}