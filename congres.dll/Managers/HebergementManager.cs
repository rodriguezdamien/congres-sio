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


        public static int AddHebergement(Hebergement newHebergement)
        {
            object id;

            SqlCommand reqAjouteHebergement = new SqlCommand("INSERT INTO HEBERGEMENT (nom, adresse, cp, ville, tel, nbEtoiles, prix) Values (@nom, @adresse, @cp, @ville, @tel, @nbEtoiles, @prix)", DBManager.ConnexionDB);

            reqAjouteHebergement.Parameters.AddWithValue("@nom", newHebergement.Nom);
            reqAjouteHebergement.Parameters.AddWithValue("@adresse", newHebergement.Adresse);
            reqAjouteHebergement.Parameters.AddWithValue("@cp", newHebergement.Cp);
            reqAjouteHebergement.Parameters.AddWithValue("@ville", newHebergement.Ville);
            reqAjouteHebergement.Parameters.AddWithValue("@tel", newHebergement.Tel);
            reqAjouteHebergement.Parameters.AddWithValue("@nbEtoiles", newHebergement.NbEtoiles);
            reqAjouteHebergement.Parameters.AddWithValue("@prix", newHebergement.Prix);

            SqlCommand reqGetId = new SqlCommand("SELECT @@IDENTITY", DBManager.ConnexionDB);

            try
            {
                DBManager.ConnexionDB.Open();
                reqAjouteHebergement.ExecuteNonQuery();
                id = reqGetId.ExecuteScalar();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return Convert.ToInt32(id);
        }

        public static void EditHebergement(Hebergement updateHebergement)
        {

            SqlCommand reqModifHebergement = new SqlCommand("UPDATE HEBERGEMENT SET nom = @nom, adresse = @adresse, cp = @cp, ville = @ville, tel = @tel, nbEtoiles = @nbEtoiles, prix = @prix where id = @id", DBManager.ConnexionDB);

            reqModifHebergement.Parameters.AddWithValue("@id", updateHebergement.Id);
            reqModifHebergement.Parameters.AddWithValue("@nom", updateHebergement.Nom);
            reqModifHebergement.Parameters.AddWithValue("@adresse", updateHebergement.Adresse);
            reqModifHebergement.Parameters.AddWithValue("@cp", updateHebergement.Cp);
            reqModifHebergement.Parameters.AddWithValue("@ville", updateHebergement.Ville);
            reqModifHebergement.Parameters.AddWithValue("@tel", updateHebergement.Tel);
            reqModifHebergement.Parameters.AddWithValue("@nbEtoiles", updateHebergement.NbEtoiles);
            reqModifHebergement.Parameters.AddWithValue("@prix", updateHebergement.Prix);

            try
            {
                DBManager.ConnexionDB.Open();
                reqModifHebergement.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

        }

        public static void DeleteHebergement(Hebergement deleteHebergement)
        {

            SqlCommand reqSupHebergement = new SqlCommand("DELETE FROM HEBERGEMENT WHERE id = @id", DBManager.ConnexionDB);

            reqSupHebergement.Parameters.AddWithValue("@id", deleteHebergement.Id);

            try
            {
                DBManager.ConnexionDB.Open();
                reqSupHebergement.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

        }

    }
}
