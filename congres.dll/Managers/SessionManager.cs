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
                SqlCommand req = new SqlCommand("SELECT id,theme,nomPresident,NbPlaces,idSalle,prix,dateSession,estMatin FROM Session", DBManager.ConnexionDB);
                SqlDataReader reader = req.ExecuteReader();
                while (reader.Read())
                {
                    sessions.Add(new Session(id: reader.GetInt32(0),
                                             theme: reader.GetString(1),
                                             nomPresident: reader.GetString(2),
                                             nbPlaces: reader.GetInt32(3),
                                             idSalle: reader.GetInt32(4),
                                             prix: reader.GetDecimal(5),
                                             dateSession:reader.GetDateTime(6),
                                             estMatin:reader.GetBoolean(7)
                                             ));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return sessions;
        }
        /// <summary>
        /// Récupération de tout les congressistes participant à la session passé en paramètre.
        /// </summary>
        /// <param name="idSession"></param>
        /// <returns></returns>
        public static List<Congressiste> GetParticipantsSession(Session uneSession)
        {
            List<Congressiste> congressistes = new List<Congressiste>();
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("SELECT c.id,c.nom,c.prenom,c.tel,c.adresse,c.cp,c.ville,c.accompte,c.idLigue,c.idHebergement " +
                                                "FROM Congressiste c " +
                                                "JOIN INSCRIRE i on i.idCongressiste = c.id " +
                                                "WHERE i.idSession = @idSession", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idSession", uneSession.Id);
                SqlDataReader reader = req.ExecuteReader();
                while (reader.Read())
                {
                    //(int id, string nom, string prenom, string tel, string adresse, string cp, string ville, decimal accompte, int idLigue, int idHebergement)
                    congressistes.Add(new Congressiste(id: reader.GetInt32(0),
                                                       nom: reader.GetString(1),
                                                       prenom: reader.GetString(2),
                                                       tel: reader.GetString(3),
                                                       adresse: reader.GetString(4),
                                                       cp: reader.GetString(5),
                                                       ville: reader.GetString(6),
                                                       accompte: reader.GetDecimal(7),
                                                       restantDu: 0,
                                                       montantTotal: 0,
                                                       idLigue:reader.GetInt32(8),
                                                       idHebergement:reader.GetInt32(9)
                                                       ));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return congressistes;
        }
        public static void AddSession(ref Session uneSession) {
            try {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("INSERT INTO Session(theme,nomPresident,NbPlaces,idSalle,prix,dateSession,estMatin) VALUES(@theme,@nomPresident,@NbPlaces,@idSalle,@prix,@dateSession,@estMatin); SELECT SCOPE_IDENTITY();", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@theme", uneSession.Theme);
                req.Parameters.AddWithValue("@nomPresident", uneSession.NomPresident);
                req.Parameters.AddWithValue("@NbPlaces", uneSession.NbPlaces);
                req.Parameters.AddWithValue("@idSalle", uneSession.LaSalle.Id);
                req.Parameters.AddWithValue("@prix", uneSession.Prix);
                req.Parameters.AddWithValue("@dateSession", uneSession.DateSession);
                req.Parameters.AddWithValue("@estMatin", uneSession.EstMatin);
                uneSession.Id = Convert.ToInt32(req.ExecuteScalar());

            } finally {
                DBManager.ConnexionDB.Close();
            }
        }

        public static void UpdateSession(Session uneSession)
        {
            try { 
            DBManager.ConnexionDB.Open();
            SqlCommand req = new SqlCommand("UPDATE Session SET theme = @theme, nomPresident = @nomPresident, NbPlaces = @NbPlaces, idSalle = @idSalle, prix = @prix, dateSession = @dateSession, estMatin = @estMatin WHERE id = @id", DBManager.ConnexionDB);
            req.Parameters.AddWithValue("@theme", uneSession.Theme);
            req.Parameters.AddWithValue("@nomPresident", uneSession.NomPresident);
            req.Parameters.AddWithValue("@NbPlaces", uneSession.NbPlaces);
            req.Parameters.AddWithValue("@idSalle", uneSession.LaSalle.Id);
            req.Parameters.AddWithValue("@prix", uneSession.Prix);
            req.Parameters.AddWithValue("@dateSession", uneSession.DateSession);
            req.Parameters.AddWithValue("@estMatin", uneSession.EstMatin);
            req.Parameters.AddWithValue("@id", uneSession.Id);
            if (req.ExecuteNonQuery() == 0)
                throw new Exception("Une erreur est survenue lors de la modification de la session.");
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
        }
        
        /// <summary>
        /// Supprime une session de la base de données.
        /// </summary>
        /// <param name="uneSession">La session que l'on souhaite supprimer.</param>
        public static void DeleteSession(Session uneSession)
        {
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("DELETE FROM Session WHERE id = @id", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@id", uneSession.Id);
                req.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

        }

        /// <summary>
        /// Ajoute un congressiste à une session.
        /// </summary>
        /// <param name="uneSession">La session où l'on souhaite ajouter le congressiste</param>
        /// <param name="unCongressiste">Le congressiste que l'on souhaite ajouter</param>
        public static void AddParticipant(Session uneSession, Congressiste unCongressiste)
        {
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("INSERT INTO INSCRIRE(idCongressiste,idSession) VALUES(@idCongressiste,@idSession)", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idCongressiste", unCongressiste.Id);
                req.Parameters.AddWithValue("@idSession", uneSession.Id);
                req.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
        }

        /// <summary>
        /// Obtient une liste de tout les congressistes ne participant pas à la session.
        /// </summary>
        /// <param name="uneSession">La session où l'on souhaite connaître les non-participants</param>
        /// <returns>Liste des congressistes non-participants.</returns>
        public static List<Congressiste> GetCongressistesNonParticipants(Session uneSession)
        {
            List<Congressiste> congressistes = new List<Congressiste>();
            try
            {
                DBManager.ConnexionDB.Open();
                //Requête avec un Not Exists et sans étoile dans la sous-requête
                SqlCommand req = new SqlCommand("SELECT c.id,c.nom,c.prenom,c.tel,c.adresse,c.cp,c.ville,c.accompte,c.idLigue,c.idHebergement " +
                                                "FROM Congressiste c " +
                                                "WHERE NOT EXISTS (SELECT i.idCongressiste FROM INSCRIRE i WHERE i.idCongressiste = c.id AND i.idSession = @idSession)", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idSession", uneSession.Id);
                SqlDataReader reader = req.ExecuteReader();
                while (reader.Read())
                {
                    congressistes.Add(new Congressiste(id: reader.GetInt32(0),
                                                       nom: reader.GetString(1),
                                                       prenom: reader.GetString(2),
                                                       tel: reader.GetString(3),
                                                       adresse: reader.GetString(4),
                                                       cp: reader.GetString(5),
                                                       ville: reader.GetString(6),
                                                       accompte: reader.GetDecimal(7),
                                                       restantDu: 0,
                                                       montantTotal: 0,
                                                       idLigue: reader.GetInt32(8),
                                                       idHebergement: reader.GetInt32(9)
                                                       ));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return congressistes;
        }

        /// <summary>
        /// Supprime un participant d'une session dans la base de données.
        /// </summary>
        /// <param name="uneSession"></param>
        /// <param name="unCongressiste"></param>
        public static void DeleteParticipant(Session uneSession, Congressiste unCongressiste)
        {
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("DELETE FROM INSCRIRE WHERE idCongressiste = @idCongressiste AND idSession = @idSession", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idCongressiste", unCongressiste.Id);
                req.Parameters.AddWithValue("@idSession", uneSession.Id);
                req.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
        }
    }
}
