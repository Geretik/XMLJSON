using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace XMLJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var file = File.ReadAllText(@"/Users/gerete/Documents/ZP4CS/XMLJSON/XMLJSON/nakaza.json");
                var json = JsonSerializer.Deserialize<Rootobject>(file);
                var infectedCount = 0;
                
                for (var i = json.data.Length - 7; i < json.data.Length; i++)
                {
                    infectedCount += json.data[i].prirustkovy_pocet_nakazenych;
                }

                infectedCount /= 7;
                Console.WriteLine(infectedCount);
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
    }
}