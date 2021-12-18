using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    class FileIOStream
    {
        private readonly string _path = "";

        public FileIOStream (string path)
        {
            _path = path;
        }
        public List <SaveClass> LoadData()
        {
            bool file = File.Exists(_path);

            if(!file)
            {
                File.CreateText(_path).Dispose();

                return new List<SaveClass>();
            }
            else
            {
                StreamReader reader = File.OpenText (_path);
                var fileText = File.ReadLines(_path).Last();
                reader.Close();                
                return JsonConvert.DeserializeObject<List<SaveClass>>(fileText);
            }

           
        }
        
        public void SaveData (List <SaveClass> saveClasses )
        {
            bool file = File.Exists(_path);
            string output;

            if (!file)
            {
                using (StreamWriter writer = File.CreateText(_path))
                {
                    output = JsonConvert.SerializeObject(saveClasses);
                    writer.Flush();
                    writer.WriteLine(output);
                    writer.Close();
                }
            }
            else
            {
                using (StreamWriter writer = File.AppendText(_path))
                {
                    output = JsonConvert.SerializeObject(saveClasses);
                    writer.Flush();
                    writer.WriteLine(output);
                    writer.Close();
                }
            }
            
           
            
           
            
        }
    }
}
