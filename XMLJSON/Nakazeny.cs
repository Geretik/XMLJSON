using System;

namespace XMLJSON
{
    public class Rootobject
    {
        public DateTime modified { get; set; }
        public string source { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string datum { get; set; }
        public int prirustkovy_pocet_nakazenych { get; set; }
        public int kumulativni_pocet_nakazenych { get; set; }
    }
    
    public class RootobjectPrumer
    {
        public DateTime modified { get; set; }
        public string source { get; set; }
        public DatumPrumer[] data { get; set; }
    }

    public class DatumPrumer
    {
        public string datum { get; set; }
        public int prirustkovy_pocet_nakazenych { get; set; }
        public int kumulativni_pocet_nakazenych { get; set; }
        public double klouzavy_prumer_7_dnu { get; set; }
    }

}