using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace congres.dll.Managers
{
    public static class SessionManager
    {
        /// <summary>
        /// Récupération de toutes les sessions présentes dans la base de données.
        /// </summary>
        /// <returns>Liste des sessions</returns>
        public static List<Session> GetSessions()
        {
            List<Session> sessions = new List<Session>();
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("SELECT id,theme,nomPresident,nbPlace,salle,prix,dateSession,estMatin FROM Session", DBManager.ConnexionDB);
                SqlDataReader reader = req.ExecuteReader();
                while (reader.Read())
                {
                    sessions.Add(new Session(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDateTime(6), reader.GetBoolean(7)));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return sessions;
        }
    }
}
