using Newtonsoft.Json;
using System;

namespace HomeTask2240
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car()
            {
                Name = "Mesdes",
                HP = 272,
                Marka = "Mesdes"
            };
            Directory.CreateDirectory(@"c:\Users\murad\OneDrive\Рабочий стол/NewFolder");
            File.Create(@"c:\Users\murad\OneDrive\Рабочий стол/NewFolder/test.txt");
            var Json = JsonConvert.SerializeObject(car);
            using (StreamWriter streamWriter = new StreamWriter(@"F:\VS pr\HomeTask2240\HomeTask2240\Jeyson.json"))
            {
                streamWriter.WriteLine(Json);
            }
            string qaqa;
            using (StreamReader streamReader = new StreamReader(@"F:\VS pr\HomeTask2240\HomeTask2240\Jeyson.json"))
            {
                qaqa = streamReader.ReadToEnd();
            }
            var Bson = JsonConvert.DeserializeObject(qaqa);
            Console.WriteLine(Bson);
        }
    }

}