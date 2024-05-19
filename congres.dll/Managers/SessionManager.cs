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
                    sessions.Add(new Session(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDateTime(6), reader.GetBoolean(7)));
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
                                                       cp:reader.GetString(5),
                                                       ville:reader.GetString(6),
                                                       accompte:reader.GetDecimal(7),
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
    }
}
