﻿using System;
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
                    sessions.Add(new Session(id: reader.GetInt32(0),
                                             theme: reader.GetString(1),
                                             nomPresident: reader.GetString(2),
                                             nbPlace: reader.GetInt32(3),
                                             salle: reader.GetString(4),
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
                                                       montantARegler: 0,
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
                SqlCommand req = new SqlCommand("INSERT INTO Session(theme,nomPresident,nbPlace,salle,prix,dateSession,estMatin) VALUES(@theme,@nomPresident,@nbPlace,@salle,@prix,@dateSession,@estMatin); SELECT SCOPE_IDENTITY();", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@theme", uneSession.Theme);
                req.Parameters.AddWithValue("@nomPresident", uneSession.NomPresident);
                req.Parameters.AddWithValue("@nbPlace", uneSession.NbPlace);
                req.Parameters.AddWithValue("@salle", uneSession.Salle);
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
            SqlCommand req = new SqlCommand("UPDATE Session SET theme = @theme, nomPresident = @nomPresident, nbPlace = @nbPlace, salle = @salle, prix = @prix, dateSession = @dateSession, estMatin = @estMatin WHERE id = @id", DBManager.ConnexionDB);
            req.Parameters.AddWithValue("@theme", uneSession.Theme);
            req.Parameters.AddWithValue("@nomPresident", uneSession.NomPresident);
            req.Parameters.AddWithValue("@nbPlace", uneSession.NbPlace);
            req.Parameters.AddWithValue("@salle", uneSession.Salle);
            req.Parameters.AddWithValue("@prix", uneSession.Prix);
            req.Parameters.AddWithValue("@dateSession", uneSession.DateSession);
            req.Parameters.AddWithValue("@estMatin", uneSession.EstMatin);
            req.Parameters.AddWithValue("@id", uneSession.Id);
            req.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
        }

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
        /// Récupération de toute les sessions auxquelles un congressiste participe.
        /// </summary>
        /// <param name="idC">id du congressiste</param>
        /// <returns>Liste des sessions</returns>
        public static List<Session> GetSessionsByCongressiste(int idC)
        {
            List<Session> sessionList = new List<Session>();

            SqlCommand reqGet = new SqlCommand("SELECT id, theme, nomPresident, nbPlace, salle, prix, dateSession, estMatin FROM INSCRIRE I " +
                "                               JOIN SESSION S on I.idSession = S.id" +
                "                               WHERE idCongressiste = @idC;", DBManager.ConnexionDB);
            reqGet.Parameters.AddWithValue("@idC", idC);

            try
            {
                DBManager.ConnexionDB.Open();
                SqlDataReader reader = reqGet.ExecuteReader();
                while (reader.Read())
                {
                    sessionList.Add(new Session(id: reader.GetInt32(0),
                                             theme: reader.GetString(1),
                                             nomPresident: reader.GetString(2),
                                             nbPlace: reader.GetInt32(3),
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
