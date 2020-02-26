using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CodingContest.Models;
using Newtonsoft.Json;

namespace CodingContest.Services 
{
    public class DataService : IDataService
    {
        private static string DATA_PATH = Path.Combine(Environment.CurrentDirectory, "Data", "exampleData.json");

        /// <summary>
        /// Initialize a new instance of <see cref="DataService" />.
        /// </summary>
        public DataService() 
        {       
            var data = GetData();
            if (data.Length == 0) 
            {
                DataService.CreateDummyData();
            }     
        }

        /// <summary>
        /// Get the data from json file.
        /// </summary>
        /// <returns></returns>
        public DataModel[] GetData()
        {
            if (!File.Exists(DATA_PATH)) 
            {
                File.Create(DATA_PATH).Dispose();
            }

            using (var stream = new StreamReader(DATA_PATH))
            {
                var json = stream.ReadToEnd();
                if (string.IsNullOrEmpty(json)) 
                {
                    json = "[]";
                }

                return JsonConvert.DeserializeObject<DataModel[]>(json);
            }
        }

        /// <summary>
        /// Get the grouping for the data.
        /// </summary>
        /// <returns>An array of <see cref="String" /></returns>
        public string[] GetGrouping()
        {
            return new string[]
            {
                "Vender", "Category", "Model"
            };
        }

        /// <summary>
        /// 
        /// </summary>
        private static void CreateDummyData()
        {
            var dummyData = new List<DataModel>();
            var vendors = new string[] 
            {
                "Acer", "Asus", "Apple", "Dell", "Fujitsu", "Hewlett Packard", "Lenovo", "Siemens"
            };

            var categories = new string[] 
            {
                "Display", "Mouse", "Keyboard", "Gaming", "GPU", "GPU ", "cpu", "CPU", "HDD/SDD", "HDD / SDD",
                "Printer", "Hardware", "Cooling Systems", "Cases", "Motherboards", "HDD", "SDD "
            };

            var models = new string[] 
            {
                "P-100A222000-A", "P-100B222000-A", "P-100C222000-A", "P-100D222000-A",
                "P-100A222000-B", "P-100B222000-B", "P-100C222000-B", "P-100D222000-B",
                "P-100A222000-C", "P-100B222000-C", "P-100C222000-C", "P-100D222000-C",
                "P-100A222000-D", "P-100B222000-D", "P-100C222000-D", "P-100D222000-D",
                "P-100A222000-E", "P-100B222000-E", "P-100C222000-E", "P-100D222000-E",
                "P-100A222000-F", "P-100B222000-F", "P-100C222000-F", "P-100D222000-F"
            };

            var random = new Random();

            for (var i = 1; i < 25000; i++)
            {
                var data = new DataModel
                {
                    Vendor = vendors[random.Next(0, vendors.Length - 1)],
                    Category = categories[random.Next(0, categories.Length - 1)],
                    Model = models[random.Next(0, models.Length - 1)],
                    Value = string.Format("Product-{0}", i)
                };

                dummyData.Add(data);
            }

            using (var fs = File.OpenWrite(DATA_PATH))
            {
                var serializedData = JsonConvert.SerializeObject(dummyData);
                var bytes = Encoding.UTF8.GetBytes(serializedData);
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}