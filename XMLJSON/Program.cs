using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Transactions;
using System.Xml;
using System.Xml.Serialization;

namespace XMLJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var filePath = @"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/studentiPredmetu.xml";
                var doc = new XmlDocument();
                var studenti = new List<studentiPredmetuStudentPredmetu>();
                doc.Load(filePath);
                var nodeList = doc.GetElementsByTagName("studentPredmetu"); // Vybrani elementu "item"
                foreach (XmlNode node in nodeList) {
                    var student = new studentiPredmetuStudentPredmetu();
                    
                    var dic = new Dictionary<string, string>();
                    

                    foreach (XmlNode child in node.ChildNodes) { // Potomci elementu
                        dic.Add(child.Name, child.InnerText);
                    }

                    if (dic["rocnik"] == "2")
                    {
                        string value = "";
                        student.osCislo = dic["osCislo"];
                        student.jmeno = dic["jmeno"];
                        student.prijmeni = dic["prijmeni"];
                        student.stav = dic["stav"];
                        student.userName = dic["userName"];
                        student.stprIdno = ushort.Parse(dic["stprIdno"]);
                        student.nazevSp = dic["nazevSp"];
                        student.fakultaSp = dic["fakultaSp"];
                        student.kodSp = dic["kodSp"];
                        student.formaSp = dic["formaSp"];
                        student.typSp = dic["typSp"];
                        student.typSpKey = byte.Parse(dic["typSpKey"]);
                        student.mistoVyuky = dic["mistoVyuky"];
                        student.rocnik = byte.Parse(dic["rocnik"]);
                        student.financovani = byte.Parse(dic["financovani"]);
                        student.oborKomb = dic["oborKomb"];
                        student.oborIdnos = dic["oborIdnos"];
                        student.email = dic["email"];
                        if (dic.TryGetValue("cisloKarty", out value))
                        {
                            student.cisloKarty = dic["cisloKarty"];
                        }
                        else
                        {
                            student.cisloKarty = value;
                        }
                        student.pohlavi = dic["pohlavi"];
                        student.evidovanBankovniUcet = dic["evidovanBankovniUcet"];
                        student.statutPredmetu = dic["evidovanBankovniUcet"];
                        studenti.Add(student);  
                    }
                    dic.Clear();
                }

                var predmet = new studentiPredmetu();
                predmet.studentPredmetu = studenti.ToArray();

                var fileName = @"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/studenti2rocniku.json";
                var jsonString = JsonSerializer.Serialize(predmet);
                File.WriteAllText(fileName, jsonString);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


            try
            {
                var file = File.ReadAllText(@"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/nakaza.json");
                var json = JsonSerializer.Deserialize<Rootobject>(file);
                
                var prumerDatum = new DatumPrumer[json.data.Length];

                for (var j = 0; j < prumerDatum.Length; j++)
                {
                    prumerDatum[j] = new DatumPrumer();
                }

                
                for (var i = 0; i < json.data.Length; i++)
                {
                    prumerDatum[i].kumulativni_pocet_nakazenych = json.data[i].kumulativni_pocet_nakazenych;
                    prumerDatum[i].prirustkovy_pocet_nakazenych = json.data[i].prirustkovy_pocet_nakazenych;
                    prumerDatum[i].datum = json.data[i].datum;
                    if (i < 7)
                    {
                        prumerDatum[i].klouzavy_prumer_7_dnu = Math.Round(KlouzavyPrumer(0, i, json), 2);
                    }
                    else
                    {
                        prumerDatum[i].klouzavy_prumer_7_dnu = Math.Round(KlouzavyPrumer(i - 7, i, json), 2);
                    }
                }

                var nakazeniKlouzavyPrumer = new RootobjectPrumer();
                nakazeniKlouzavyPrumer.data = prumerDatum;
                nakazeniKlouzavyPrumer.source = json.source;
                nakazeniKlouzavyPrumer.modified = DateTime.Now;
                
                var tw = new StreamWriter(@"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/Nakazeni_klouzavy_prumer.xml");
                var sr = new XmlSerializer(typeof(RootobjectPrumer));
                sr.Serialize(tw, nakazeniKlouzavyPrumer);
                tw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            try
            {
                var f = new FileStream(@"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/predmetyKatedry.xml",
                    FileMode.Open);
                var serializer = new XmlSerializer(typeof(predmetyKatedry));
                var item = (predmetyKatedry) serializer.Deserialize(f);
                f.Close();

                var haf = new predmetyKatedryPredmetKatedry[20];

                for (var i = 0; i < 20; i++)
                {
                    haf[i] = item.predmetKatedry[i];
                }

                var item20 = new predmetyKatedry();
                item20.predmetKatedry = haf;
                
                var tw = new StreamWriter(@"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/20predmetu.xml");
                var sr = new XmlSerializer(typeof(predmetyKatedry));
                sr.Serialize(tw, item20);
                tw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public static double KlouzavyPrumer(int from, int to, Rootobject d)
        {
            var infectedCount = 0.0;
            for (var i = from; i < to; i++)
            {
                infectedCount += d.data[i].prirustkovy_pocet_nakazenych;
            }

            if (to > 0)
            {
                infectedCount /= to - from;
                return infectedCount;
            }
            return 0;
        }

    }
}