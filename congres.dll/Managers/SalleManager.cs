using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll.Managers
{
    public class SalleManager
    {
        /// <summary>
        /// Permet d'obtenir la liste des toutes les salles.
        /// </summary>
        /// <returns>liste d'objet Salles</returns>
        public static List<Salle> GetSalles()
        {
            List<Salle> salles = new List<Salle>();
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("SELECT id, libelle FROM Salle", DBManager.ConnexionDB);
                SqlDataReader reader = req.ExecuteReader();
                while (reader.Read())
                {
                    salles.Add(new Salle(id: reader.GetInt32(0), libelle: reader.GetString(1)));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return salles;
        }

        /// <summary>
        /// Permet d'ajouter une nouvelle salle.
        /// </summary>
        /// <param name="newSalle">objet salle</param>
        /// <returns>l'id de la salle ajouté</returns>
        public static int AddSalle(Salle newSalle)
        {
            object id;

            SqlCommand reqAjoutSalle = new SqlCommand("INSERT INTO SALLE (libelle) Values (@libelle)", DBManager.ConnexionDB);

            reqAjoutSalle.Parameters.AddWithValue("@libelle", newSalle.Libelle);

            SqlCommand reqGetId = new SqlCommand("SELECT @@IDENTITY", DBManager.ConnexionDB);

            try
            {
                DBManager.ConnexionDB.Open();
                reqAjoutSalle.ExecuteNonQuery();
                id = reqGetId.ExecuteScalar();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// Permet de mettre à jour les informations d'une salle
        /// </summary>
        /// <param name="updateSalle">objet salle</param>
        public static void EditSalle(Salle updateSalle)
        {

            SqlCommand reqModifSalle = new SqlCommand("UPDATE SALLE SET libelle = @libelle where id = @id", DBManager.ConnexionDB);

            reqModifSalle.Parameters.AddWithValue("@libelle", updateSalle.Libelle);
            reqModifSalle.Parameters.AddWithValue("@id", updateSalle.Id);

            try
            {
                DBManager.ConnexionDB.Open();
                reqModifSalle.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

        }

        /// <summary>
        /// Permet de supprimer une salle.
        /// </summary>
        /// <param name="deleteSalle">objet salle</param>
        public static void DeleteSalle(Salle deleteSalle)
        {

            SqlCommand reqSupSalle = new SqlCommand("DELETE FROM SALLE WHERE id = @id", DBManager.ConnexionDB);

            reqSupSalle.Parameters.AddWithValue("@id", deleteSalle.Id);

            try
            {
                DBManager.ConnexionDB.Open();
                reqSupSalle.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

        }

        /// <summary>
        /// Retourne la liste des sessions pour une salle donné.
        /// </summary>
        /// <param name="uneSalle">objet salle</param>
        /// <returns>liste d'objet Session</returns>
        public static List<Session> GetSessionsBySalle(Salle uneSalle)
        {
            List<Session> sessionList = new List<Session>();

            SqlCommand reqGet = new SqlCommand("SELECT id, theme, nomPresident, NbPlaces, prix, dateSession, estMatin FROM Session  " +
                "WHERE idSalle = @idSalle;", DBManager.ConnexionDB);
            reqGet.Parameters.AddWithValue("@idSalle", uneSalle.Id);

            try
            {
                DBManager.ConnexionDB.Open();
                SqlDataReader reader = reqGet.ExecuteReader();
                while (reader.Read())
                {
                    sessionList.Add(new Session(id: reader.GetInt32(0),
                                             theme: reader.GetString(1),
                                             nomPresident: reader.GetString(2),
                                             nbPlaces: reader.GetInt32(3),
                                             idSalle: uneSalle.Id,
                                             prix: reader.GetDecimal(4),
                                             dateSession: reader.GetDateTime(5),
                                             estMatin: reader.GetBoolean(6)
                                             ));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return sessionList;
        }

    }
}
