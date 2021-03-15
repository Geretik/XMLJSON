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
            var filePathStudentiPredmetu = @"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/studentiPredmetu.xml";
            var filePathStudenti2Rocniku = @"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/studenti2rocniku.json";
            var filePathNakaza = @"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/nakaza.json";
            var filePathNakazaPrumer = @"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/Nakazeni_klouzavy_prumer.xml";
            var filePathPredmetyKatedry = @"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/predmetyKatedry.xml";
            var filePath20PredmetuKatedry = @"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/20predmetu.xml";
            
            try
            {
                
                var doc = new XmlDocument();
                var studenti = new List<studentiPredmetuStudentPredmetu>();
                doc.Load(filePathStudentiPredmetu);
                var nodeList = doc.GetElementsByTagName("studentPredmetu"); // Vybrani elementu "item"
                foreach (XmlNode node in nodeList)
                {
                    var student = new studentiPredmetuStudentPredmetu();

                    var dic = new Dictionary<string, string>();


                    foreach (XmlNode child in node.ChildNodes)
                    {
                        // Potomci elementu
                        dic.Add(child.Name, child.InnerText);
                    }

                    if (dic["rocnik"] == "2")
                    {
                        string value = "";
                        if (dic.TryGetValue("osCislo", out value))
                        {
                            student.osCislo = dic["osCislo"];
                        }
                        else
                        {
                            student.osCislo = value;
                        }

                        if (dic.TryGetValue("jmeno", out value))
                        {
                            student.jmeno = dic["jmeno"];
                        }
                        else
                        {
                            student.jmeno = value;
                        }

                        if (dic.TryGetValue("prijmeni", out value))
                        {
                            student.prijmeni = dic["prijmeni"];
                        }
                        else
                        {
                            student.prijmeni = value;
                        }

                        if (dic.TryGetValue("stav", out value))
                        {
                            student.stav = dic["stav"];
                        }
                        else
                        {
                            student.stav = value;
                        }

                        if (dic.TryGetValue("userName", out value))
                        {
                            student.userName = dic["userName"];
                        }
                        else
                        {
                            student.userName = value;
                        }

                        if (dic.TryGetValue("stprIdno", out value))
                        {
                            student.stprIdno = ushort.Parse(dic["stprIdno"]);
                        }
                        else
                        {
                            student.stprIdno = 0;
                        }

                        if (dic.TryGetValue("nazevSp", out value))
                        {
                            student.nazevSp = dic["nazevSp"];
                        }
                        else
                        {
                            student.nazevSp = value;
                        }

                        if (dic.TryGetValue("fakultaSp", out value))
                        {
                            student.fakultaSp = dic["fakultaSp"];
                        }
                        else
                        {
                            student.fakultaSp = value;
                        }

                        if (dic.TryGetValue("kodSp", out value))
                        {
                            student.kodSp = dic["kodSp"];
                        }
                        else
                        {
                            student.kodSp = value;
                        }

                        if (dic.TryGetValue("formaSp", out value))
                        {
                            student.formaSp = dic["formaSp"];
                        }
                        else
                        {
                            student.formaSp = value;
                        }

                        if (dic.TryGetValue("typSp", out value))
                        {
                            student.typSp = dic["typSp"];
                        }
                        else
                        {
                            student.typSp = value;
                        }

                        if (dic.TryGetValue("typSpKey", out value))
                        {
                            student.typSpKey = byte.Parse(dic["typSpKey"]);
                        }
                        else
                        {
                            student.typSpKey = 0;
                        }

                        if (dic.TryGetValue("mistoVyuky", out value))
                        {
                            student.mistoVyuky = dic["mistoVyuky"];
                        }
                        else
                        {
                            student.mistoVyuky = value;
                        }

                        if (dic.TryGetValue("rocnik", out value))
                        {
                            student.rocnik = byte.Parse(dic["rocnik"]);
                        }
                        else
                        {
                            student.rocnik = 0;
                        }

                        if (dic.TryGetValue("financovani", out value))
                        {
                            student.financovani = byte.Parse(dic["financovani"]);
                        }
                        else
                        {
                            student.financovani = 0;
                        }

                        if (dic.TryGetValue("oborKomb", out value))
                        {
                            student.oborKomb = dic["oborKomb"];
                        }
                        else
                        {
                            student.oborKomb = value;
                        }

                        if (dic.TryGetValue("oborIdnos", out value))
                        {
                            student.oborIdnos = dic["oborIdnos"];
                        }
                        else
                        {
                            student.oborIdnos = value;
                        }

                        if (dic.TryGetValue("email", out value))
                        {
                            student.email = dic["email"];
                        }
                        else
                        {
                            student.email = value;
                        }

                        if (dic.TryGetValue("cisloKarty", out value))
                        {
                            student.cisloKarty = dic["cisloKarty"];
                        }
                        else
                        {
                            student.cisloKarty = value;
                        }

                        if (dic.TryGetValue("pohlavi", out value))
                        {
                            student.pohlavi = dic["pohlavi"];
                        }
                        else
                        {
                            student.pohlavi = value;
                        }

                        if (dic.TryGetValue("evidovanBankovniUcet", out value))
                        {
                            student.evidovanBankovniUcet = dic["evidovanBankovniUcet"];
                        }
                        else
                        {
                            student.evidovanBankovniUcet = value;
                        }

                        if (dic.TryGetValue("statutPredmetu", out value))
                        {
                            student.statutPredmetu = dic["statutPredmetu"];
                        }
                        else
                        {
                            student.statutPredmetu = value;
                        }
                        studenti.Add(student);
                        dic.Clear();
                    }
                }

                var predmet = new studentiPredmetu();
                predmet.studentPredmetu = studenti.ToArray();
                
                // var jsonString = JsonSerializer.Serialize(predmet);
                //
                // File.WriteAllText(fileName, jsonString);
                //

                byte[] jsonUtf8Bytes;
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(predmet, options);

                File.WriteAllBytes(filePathStudenti2Rocniku, jsonUtf8Bytes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            try
            {
                var file = File.ReadAllText(filePathNakaza);
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
                    if (i < 6)
                    {
                        prumerDatum[i].klouzavy_prumer_7_dnu = (int) (Math.Round(KlouzavyPrumer(0, i, json), 0));
                    }
                    else
                    {
                        prumerDatum[i].klouzavy_prumer_7_dnu = (int) Math.Round(KlouzavyPrumer(i - 6, i, json), 0);
                    }
                }

                var nakazeniKlouzavyPrumer = new RootobjectPrumer();
                nakazeniKlouzavyPrumer.data = prumerDatum;
                nakazeniKlouzavyPrumer.source = json.source;
                nakazeniKlouzavyPrumer.modified = DateTime.Now;

                var tw = new StreamWriter(
                    filePathNakazaPrumer);
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
                var f = new FileStream(filePathPredmetyKatedry,
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

                var tw = new StreamWriter(filePath20PredmetuKatedry);
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
            for (var i = from; i <= to; i++)
            {
                infectedCount += d.data[i].prirustkovy_pocet_nakazenych;
            }

            if (to > 0)
            {
                infectedCount /= to - from + 1;
                return infectedCount;
            }
            return 0;
        }
    }
}