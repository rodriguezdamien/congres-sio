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

        public static List<Session> GetSessionsBySalle(int idSalle)
        {
            List<Session> sessionList = new List<Session>();

            SqlCommand reqGet = new SqlCommand("SELECT id, theme, nomPresident, NbPlaces, salle, prix, dateSession, estMatin FROM Session  " +
                "WHERE idSalle = @idSalle;", DBManager.ConnexionDB);
            reqGet.Parameters.AddWithValue("@idSalle", idSalle);

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
                                             salle: reader.GetString(4),
                                             prix: reader.GetDecimal(5),
                                             dateSession: reader.GetDateTime(6),
                                             estMatin: reader.GetBoolean(7)
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
