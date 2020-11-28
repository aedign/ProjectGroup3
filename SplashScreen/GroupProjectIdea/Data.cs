using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProjectIdea;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;

namespace GroupProjectIdea
{
    public class Data
    {

        public List<Project> projects = new List<Project>();
        Project empty = null;
        private String dataPath = "DataFile.txt";

        public Data()
        {
            var systemPath = System.Environment.
                             GetFolderPath(
                                 Environment.SpecialFolder.CommonApplicationData
                             );
            dataPath = Path.Combine(systemPath, "DataFile.txt");
        }

        public void checkPath()
        {
            if (!File.Exists(dataPath))
            {
                StreamWriter stream = new StreamWriter(dataPath);
                stream.Write("");
                stream.Close();
            }
        }

        //loads the database from the file to the list
        public List<Project> getDatabase()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            String filedata = File.ReadAllText(dataPath);
            if (filedata.Equals(""))
            {
                Project empty = new Project("empty");
                projects.Add(empty);
                setDatabase(projects);
            }
            projects = JsonSerializer.Deserialize<List<Project>>(File.ReadAllText(dataPath));
            return projects;
        }

        //saves the current database list to the file make asynchronous
        public void setDatabase(List<Project> save)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            String jason = JsonSerializer.Serialize<List<Project>>(save, options);
            File.WriteAllText(dataPath, jason);
        }
    }
}
