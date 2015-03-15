using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IUT.Bamboue.Outils;
using IUT.Bamboue.Data;
using IUT.Bamboue.Domaine;

namespace IUT.Bamboue.Services
{
    public class Services
    {
        static DataBamboue dtb = new DataBamboue();

        /// <summary>
        /// Méthode retournant un DataSet toutes contenant les données d'un champ en fonction de son Id.
        /// </summary>
        /// <param name="id">Id du champ</param>
        /// <returns>DataSet</returns>
        public Champ getChampById(int id)
        {
            return null;
        }


        /// <summary>
        /// Méthode retournant une liste contenant toutes les installations
        /// </summary>
        /// <returns>DataSet</returns>
        public List<Champ> getAllInstallations()
        {
            return null;
        }

        /// <summary>
        /// Méthode retournant un Champ correspondant à l'id de l'installation passé en paramètre
        /// </summary>
        /// <param name="idInstall">Id de l'installation</param>
        /// <returns>DataSet</returns>
        public Champ getChampByIdInstallation(int idInstall)
        {
            return null;
        }
    }
}
