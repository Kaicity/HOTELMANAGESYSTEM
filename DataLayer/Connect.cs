using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public class Connect
    {
        private string servername;
        private string usersername;
        private string password;
        private string database;

        public Connect(string servername, string usersername, string password, string database)
        {
            this.Servername = servername;
            this.Usersername = usersername;
            this.Password = password;
            this.Database = database;
        }

        public string Servername { get => servername; set => servername = value; }
        public string Usersername { get => usersername; set => usersername = value; }
        public string Password { get => password; set => password = value; }
        public string Database { get => database; set => database = value; }

        public void saveFiles()
        {
            if (File.Exists("connectdb.dba"))
                File.Delete("connectdb.dba");

            FileStream fs = File.Open("connectdb.dba", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
