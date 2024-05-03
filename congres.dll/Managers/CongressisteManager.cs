using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll.Managers
{
    public class CongressisteManager
    {
        /// <summary>
        /// Permet de récupérer la liste des conggressistes
        /// </summary>
        /// <returns>Liste d'objet congressiste</returns>
        public static List<Congressiste> GetCongressistes()
        {
            List<Congressiste> lesCongressistes = new List<Congressiste>();
            SqlCommand reqGet = new SqlCommand("SELECT id, nom, prenom, tel, adresse, cp, ville, accompte, idLigue, idHebergement FROM CONGRESSISTE", DBManager.ConnexionDB);
            
            try
            {
                SqlDataReader reader = reqGet.ExecuteReader();
                while (reader.Read())
                {
                    DBManager.ConnexionDB.Open();
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string tel = reader.GetString(3);
                    string adresse = reader.GetString(4);
                    string cp = reader.GetString(5);
                    string ville = reader.GetString(6);
                    decimal accompte = reader.GetDecimal(7);
                    int idLigue = reader.GetInt32(8);
                    int idHebergement = reader.GetInt32(9);

                    lesCongressistes.Add(new Congressiste(id, nom, prenom, tel, adresse, cp, ville, accompte, idLigue, idHebergement));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return lesCongressistes;
        }

        public static bool AddCongressiste(Congressiste congressiste)
        {
            bool isAdded = false;

            SqlCommand reqAdd = new SqlCommand("INSERT INTO CONGRESSISTE (id, nom, prenom, tel, adresse, cp, ville, accompte, idLigue, idHebergement) VALUES (@id, @n, @p, @t, @a, @cp, @v, @accompte, @idL, @idH", DBManager.ConnexionDB);
            reqAdd.Parameters.AddWithValue("@id", congressiste.Id);
            reqAdd.Parameters.AddWithValue("@n", congressiste.Nom);
            reqAdd.Parameters.AddWithValue("@p", congressiste.Prenom);
            reqAdd.Parameters.AddWithValue("@t", congressiste.Tel);
            reqAdd.Parameters.AddWithValue("@a", congressiste.Adresse);
            reqAdd.Parameters.AddWithValue("@cp", congressiste.Cp);
            reqAdd.Parameters.AddWithValue("@v", congressiste.Ville);
            reqAdd.Parameters.AddWithValue("@accompte", congressiste.Accompte);
            if(congressiste.IdLigue == null)
            {
                reqAdd.Parameters.AddWithValue("@idL", DBNull.Value);
            }
            else
            {
                reqAdd.Parameters.AddWithValue("@idL", congressiste.IdLigue);
            }
            if (congressiste.IdHebergement == null)
            {
                reqAdd.Parameters.AddWithValue("@idH", DBNull.Value);
            } 
            else
            {

                reqAdd.Parameters.AddWithValue("@idH", congressiste.IdHebergement);
            }

            try
            {
                DBManager.ConnexionDB.Open();
                int ligneAjt = reqAdd.ExecuteNonQuery();
                //if simplifié
                if (ligneAjt > 0) isAdded = true;
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return isAdded;
        }

        public static bool UpdtCongressiste(Congressiste congressiste)
        {
            bool isUpdt = false;

            SqlCommand reqUdpt = new SqlCommand("UPDATE CONGRESSISTE SET nom = @n, prenom = @p, tel = @t, adresse = @a, cp = @cp, ville = @v, accompte = @accompte, idLigue = @idL, idHebergement = @idH WHERE id = @id", DBManager.ConnexionDB);
            reqUdpt.Parameters.AddWithValue("@id", congressiste.Id);
            reqUdpt.Parameters.AddWithValue("@n", congressiste.Nom);
            reqUdpt.Parameters.AddWithValue("@p", congressiste.Prenom);
            reqUdpt.Parameters.AddWithValue("@t", congressiste.Tel);
            reqUdpt.Parameters.AddWithValue("@a", congressiste.Adresse);
            reqUdpt.Parameters.AddWithValue("@cp", congressiste.Cp);
            reqUdpt.Parameters.AddWithValue("@v", congressiste.Ville);
            reqUdpt.Parameters.AddWithValue("@accompte", congressiste.Accompte);
            if (congressiste.IdLigue == null)
            {
                reqUdpt.Parameters.AddWithValue("@idL", DBNull.Value);
            }
            else
            {
                reqUdpt.Parameters.AddWithValue("@idL", congressiste.IdLigue);
            }
            if (congressiste.IdHebergement == null)
            {
                reqUdpt.Parameters.AddWithValue("@idH", DBNull.Value);
            }
            else
            {

                reqUdpt.Parameters.AddWithValue("@idH", congressiste.IdHebergement);
            }

            try
            {
                DBManager.ConnexionDB.Open();
                int ligneUpdt = reqUdpt.ExecuteNonQuery();
                //if simplifié
                if (ligneUpdt > 0) isUpdt = true;
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return isUpdt;
        }
    }
}
