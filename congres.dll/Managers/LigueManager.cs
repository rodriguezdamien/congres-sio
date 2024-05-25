using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace congres.dll.Managers
{
    public static class LigueManager
    {
        /// <summary>
        /// Permet de retourner la liste des ligues.
        /// </summary>
        /// <returns>Liste d'objet Ligue</returns>
        public static List<Ligue> GetLigues()
        {
            List<Ligue> ligues = new List<Ligue>();

            SqlCommand reqGet = new SqlCommand("SELECT id,nomLigue,adresse,cp,ville FROM Ligue", DBManager.ConnexionDB);

            try
            {
                DBManager.ConnexionDB.Open();
                SqlDataReader reader = reqGet.ExecuteReader();
                while (reader.Read())
                {
                    ligues.Add(new Ligue(id: reader.GetInt32(0), 
                                         nomLigue: reader.GetString(1), 
                                         adresse: reader.GetString(2), 
                                         codePostal: reader.GetString(3), 
                                         ville: reader.GetString(4)));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return ligues;
        }

        /// <summary>
        /// Permet l'ajout d'une ligue.
        /// </summary>
        /// <param name="ligue">objet ligue</param>
        /// <returns>l'id de la nouvelle ligue ajouté</returns>
        public static int AddLigue(Ligue ligue)
        {
            object id;

            SqlCommand reqAdd = new SqlCommand("INSERT INTO LIGUE (nomLigue,adresse,cp,ville) VALUES (@n, @a, @cp, @v);", DBManager.ConnexionDB);
            reqAdd.Parameters.AddWithValue("@n", ligue.Nom);
            reqAdd.Parameters.AddWithValue("@a", ligue.Adresse);
            reqAdd.Parameters.AddWithValue("@cp", ligue.CodePostal);
            reqAdd.Parameters.AddWithValue("@v", ligue.Ville);

            SqlCommand reqGetId = new SqlCommand("SELECT @@IDENTITY", DBManager.ConnexionDB);

            try
            {
                DBManager.ConnexionDB.Open();
                reqAdd.ExecuteNonQuery();
                id = reqGetId.ExecuteScalar();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// Permet de mettre à jour les informations d'une ligue.
        /// </summary>
        /// <param name="ligue">objet ligue qui sera mit à jour</param>
        /// <returns>true: si la modification à été faite, false: si la modification n'as pas été faite</returns>
        public static bool UpdtLigue(Ligue ligue)
        {
            bool isUdpt = false;

            SqlCommand reqUpdt = new SqlCommand("UPDATE LIGUE SET nomLigue = @nomL, adresse = @a, cp = @cp, ville = @v WHERE id = @idL", DBManager.ConnexionDB);
            reqUpdt.Parameters.AddWithValue("@nomL", ligue.Nom);
            reqUpdt.Parameters.AddWithValue("@a", ligue.Adresse);
            reqUpdt.Parameters.AddWithValue("@cp", ligue.CodePostal);
            reqUpdt.Parameters.AddWithValue("@v", ligue.Ville);
            reqUpdt.Parameters.AddWithValue("@idL", ligue.Id);

            try
            {
                DBManager.ConnexionDB.Open();
                if (reqUpdt.ExecuteNonQuery() > 0) isUdpt = true;
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return isUdpt;
        }

        /// <summary>
        /// Permet de supprimer une ligue.
        /// </summary>
        /// <param name="idL">id de la ligue à supprimer</param>
        /// <returns>true: si la suppression à été faite, false: si la suppression n'as pas été faite</returns>
        public static bool DelLigue(int idL)
        {
            bool isDel = false;

            SqlCommand sqlCommand = new SqlCommand("DELETE LIGUE WHERE id = @idL", DBManager.ConnexionDB);
            sqlCommand.Parameters.AddWithValue("@idL", idL);

            try
            {
                DBManager.ConnexionDB.Open();
                if(sqlCommand.ExecuteNonQuery()>0) isDel = true;
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return isDel;
        }

        /// <summary>
        /// Retourne la liste des congressiste en fonction de la ligue.
        /// </summary>
        /// <param name="idL">id de la ligue</param>
        /// <returns>liste d'obejt Congressiste</returns>
        public static List<Congressiste> GetCongressisteByLigue(int idL)
        {
            List<Congressiste> lesC = new List<Congressiste>();

            SqlCommand reqGetC = new SqlCommand("SELECT id, nom, prenom FROM CONGRESSISTE WHERE idLigue = @idL", DBManager.ConnexionDB);
            reqGetC.Parameters.AddWithValue("@idL", idL);

            try
            {
                DBManager.ConnexionDB.Open();
                SqlDataReader reader = reqGetC.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);

                    lesC.Add(new Congressiste(id, nom, prenom));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return lesC;
        }
    }
}
