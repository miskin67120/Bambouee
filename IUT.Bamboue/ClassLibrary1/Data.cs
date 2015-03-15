using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IUT.Bamboue.Outils;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace IUT.Bamboue.Data
{
    public class DataBamboue
    {
        /// <summary>
        /// Chaine de connexion permettant d'accéder à la base de données
        /// </summary>
        ConnectionStringSettings connec = new ConnectionStringSettings("Bamboue", ConfigurationManager.ConnectionStrings["BamboueConnectionString"].ConnectionString, "System.Data.OleDb");


        /// <summary>
        /// Méthode retournant un DataSet toutes contenant les données d'un champ en fonction de son Id.
        /// </summary>
        /// <param name="id">Id du champ</param>
        /// <returns>DataSet</returns>
        public DataSet getChampById(int id)
        {
            return null;
        }


        /// <summary>
        /// Méthode retournant un DataSet contenant toutes les installations
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet getAllInstallations()
        {
            return null;
        }


        /// <summary>
        /// Méthode retournant un DataSet contenant le champ correspondant à l'id de l'installation passé en paramètre
        /// </summary>
        /// <param name="idInstall">Id de l'installation</param>
        /// <returns>DataSet</returns>
        public DataSet getChampByIdInstallation(int idInstall)
        {
            return null;
        }


        /// <summary>
        /// Méthode mettant à jour la BDD en fonction d'un dataSet de champ passé en paramètre
        /// </summary>
        /// <param name="ds">DataSet du champ à mettre à jour</param>
        public void updateChamp(DataSet ds)
        {
        }
    }
}
