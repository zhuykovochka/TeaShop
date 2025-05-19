using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TeaShop.Models;

namespace TeaShop.Services
{
    public class JsonDataService
    {
        public List<Product> LoadProducts(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл с товарами не найден!");

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
}
