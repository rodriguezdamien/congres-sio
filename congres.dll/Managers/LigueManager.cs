using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace congres.dll.Managers
{
    public static class LigueManager
    {
        public static List<Ligue> GetLigues()
        {
            List<Ligue> ligues = new List<Ligue>();
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("SELECT id,nomLigue,adresse,cp,ville FROM Ligue", DBManager.ConnexionDB);
                SqlDataReader reader = req.ExecuteReader();
                while (reader.Read())
                {
                    ligues.Add(new Ligue(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return ligues;
        }
    }
}
