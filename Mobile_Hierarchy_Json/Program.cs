using Mobile_Hierarchy.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mobile_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile iPhone_X = new IPhone_X(DateTime.Now, RAM.ram4, Storage.stor64);
            Mobile xiaomi_Redmi_Note_9S = new Xiaomi_Redmi_Note_9S(DateTime.Now, RAM.ram4, Storage.stor128);
            Mobile nokia_Lumia_930 = new Nokia_Lumia_930(DateTime.Now, RAM.ram2, Storage.stor16);

            string iPhoneXFileName = "IPhoneX.txt";
            SaveAsJsonFormat(iPhone_X, iPhoneXFileName);

            IPhone_X iPhone_X_From_JSON = LoadFromJSONFile(iPhoneXFileName);

            PrintInfoAboutPhone(iPhone_X_From_JSON);

            //PrintInfoAboutPhone(iPhone_X, xiaomi_Redmi_Note_9S, nokia_Lumia_930);

            Console.Read();
        }

        static void SaveAsJsonFormat(object objGraph, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(objGraph);
            File.WriteAllText(fileName, jsonString);
        }

        static IPhone_X LoadFromJSONFile(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            IPhone_X iPhone_X = JsonSerializer.Deserialize<IPhone_X>(jsonString);

            return iPhone_X;
        }

        static void PrintInfoAboutPhone(params Mobile[] mobiles)
        {
            foreach (var mobile in mobiles)
            {
                Console.WriteLine("- Company: " + mobile.Company);
                Console.WriteLine("- Name: " + mobile.Name);
                Console.WriteLine("- Release Date: " + mobile.ReleaseDate);
                Console.WriteLine("- OS: " + mobile.OS);
                Console.WriteLine("- RAM: " + (int)mobile.RAM + "GB");
                Console.WriteLine("- Storage: " + (int)mobile.Storage + "GB");
                Console.WriteLine("- CPU: " + mobile.CPU);
                Console.WriteLine("- Battery: " + mobile.Battery + "mAh");
                Console.WriteLine("- Rear Camera: " + mobile.RearCamera + "MP");
                Console.WriteLine("- Front Camera: " + mobile.FrontCamera + "MP");
                Console.WriteLine("- Weight: " + mobile.Weight + "g");
                Console.WriteLine("- Dimensions: " + mobile.Dimensions.Height + "x" + mobile.Dimensions.Width + "x" + mobile.Dimensions.Thickness + "mm");
                Console.WriteLine();
            }
        }
    }
}
