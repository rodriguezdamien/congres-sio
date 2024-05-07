using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll.Managers
{
    public class HebergementManager
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Hebergement> GetHebergements()
        {
            List<Hebergement> hebergements = new List<Hebergement>();
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("Select id, nom, adresse, cp, ville, tel, nbEtoiles, prix From Hebergement", DBManager.ConnexionDB);
                SqlDataReader reader = req.ExecuteReader();
                while (reader.Read())
                {



                    hebergements.Add(new Hebergement(id : reader.GetInt32(0), nom : reader.GetString(1), adresse : reader.GetString(2), cp : reader.GetString(3), ville : reader.GetString(4), tel : reader.GetString(5), nbEtoiles : reader.GetString(6), prix : reader.GetDecimal(7)));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return hebergements;
        }


    }
}
