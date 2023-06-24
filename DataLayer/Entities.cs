using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public partial class Entities
    {
        public Entities(DbConnection connectionString, bool contextOwnsConnection = true)
            : base(connectionString, contextOwnsConnection) { }

        public static Entities CreateEntities(bool contextOwnsConnection = true)
        {
            //Doc file connect
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            Connect cp = (Connect)bf.Deserialize(fs);

            //Descrypt noi dung
            string servername = Encrytor.Descrypt(cp.Servername, "qwertyuiop", true);
            string username = Encrytor.Descrypt(cp.Usersername, "qwertyuiop", true);
            string pass = Encrytor.Descrypt(cp.Password, "qwertyuiop", true);
            string database = Encrytor.Descrypt(cp.Database, "qwertyuiop", true);

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            SqlConnectionStringBuilder sqlConnectBuilder = new SqlConnectionStringBuilder();
            sqlConnectBuilder.DataSource= servername;
            sqlConnectBuilder.InitialCatalog = database;
            sqlConnectBuilder.UserID = username;
            sqlConnectBuilder.Password = pass;

            string sqlConnectString = sqlConnectBuilder.ConnectionString;

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectString;

            entityBuilder.Metadata = @"res://*/KHACHSAN.csdl|res://*/KHACHSAN.ssdl|res://*/KHACHSAN.msl";

            EntityConnection connection = new EntityConnection(entityBuilder.ConnectionString);

            fs.Close();

            return new Entities(connection);
        }
    }
}
