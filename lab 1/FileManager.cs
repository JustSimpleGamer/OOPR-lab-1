using lab_1.Models;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_1
{
    public class FileManager
    { 
        public string FileName { get; set; }

        public FileManager(string fileName)
        {
            this.FileName = fileName;
        }
        public void Save(List<StudentVm> students)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
            }
        }
        public List<StudentVm> Load()
        {
            List<StudentVm> students = new List<StudentVm>();

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                students = (List<StudentVm>)formatter.Deserialize(fs);
            }

            return students;
        }
    }
}
