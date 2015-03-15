using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace IUT.Bamboue.Outils
{
    public class DataOutils
    {
        #region BuildDataSet
        // Méthode qui permet de construir un DataSet à partir d'une requête
        public static DataSet BuildDataSet(String CommandText, ConnectionStringSettings connectionString)
        {
            DataSet ds = null;
            DbProviderFactory factory = DbProviderFactories.GetFactory(connectionString.ProviderName);
            using (IDbConnection connection = factory.CreateConnection())
            {
                //attribution de la chaine de connexion à l'objet connection
                connection.ConnectionString = connectionString.ConnectionString;
                connection.Open();
                //création et configuration de l'objet command
                IDbCommand command = factory.CreateCommand();
                command.CommandText = CommandText;
                command.Connection = connection;
                IDbDataAdapter sqlAdapt = factory.CreateDataAdapter();
                sqlAdapt.SelectCommand = command;
                ds = new DataSet("dataset");
                sqlAdapt.Fill(ds);
                connection.Close();
                connection.Dispose();
            }
            return ds;
        }
        #endregion 
    }
}
