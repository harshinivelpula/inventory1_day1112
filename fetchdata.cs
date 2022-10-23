using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory1
{
    internal class fetchdata
    {
        public inventory Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<inventory>(json);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
