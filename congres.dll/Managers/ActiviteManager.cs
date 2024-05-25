using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace congres.dll.Managers
{
    public static class ActiviteManager
    {
        /// <summary>
        /// Récupération de toutes les Activites présentes dans la base de données.
        /// </summary>
        /// <returns>Liste des Activites</returns>
        public static List<Activite> GetActivites()
        {
            List<Activite> Activites = new List<Activite>();
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("SELECT id,nom,NbPlaces,prix,dateActivite,estMatin FROM Activite", DBManager.ConnexionDB);
                SqlDataReader reader = req.ExecuteReader();
                while (reader.Read())
                {
                    Activites.Add(new Activite(id: reader.GetInt32(0),
                                             nom: reader.GetString(1),
                                             nbPlaces: reader.GetInt32(2),
                                             prix: reader.GetDecimal(3),
                                             dateActivite:reader.GetDateTime(4),
                                             estMatin:reader.GetBoolean(5)
                                             ));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return Activites;
        }
        /// <summary>
        /// Récupération de tout les congressistes participant à l'activité passé en paramètre.
        /// </summary>
        /// <param name="idActivite"></param>
        /// <returns></returns>
        public static List<Congressiste> GetParticipantsActivite(Activite uneActivite)
        {
            List<Congressiste> congressistes = new List<Congressiste>();
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("SELECT c.id,c.nom,c.prenom,c.tel,c.adresse,c.cp,c.ville,c.accompte,c.idLigue,c.idHebergement " +
                                                "FROM Congressiste c " +
                                                "JOIN PARTICIPER p on p.idCongressiste = c.id " +
                                                "WHERE p.idActivite = @idActivite", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idActivite", uneActivite.Id);
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

        /// <summary>
        /// Permet l'ajout d'une acitivité.
        /// </summary>
        /// <param name="uneActivite">objet Activite</param>
        public static void AddActivite(ref Activite uneActivite) {
            try {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("INSERT INTO Activite(nom,NbPlaces,prix,dateActivite,estMatin) VALUES(@nom,@NbPlaces,@prix,@dateActivite,@estMatin); SELECT SCOPE_IDENTITY();", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@nom", uneActivite.Nom);
                req.Parameters.AddWithValue("@NbPlaces", uneActivite.NbPlaces);
                req.Parameters.AddWithValue("@prix", uneActivite.Prix);
                req.Parameters.AddWithValue("@dateActivite", uneActivite.DateActivite);
                req.Parameters.AddWithValue("@estMatin", uneActivite.EstMatin);
                uneActivite.Id = Convert.ToInt32(req.ExecuteScalar());

            } finally {
                DBManager.ConnexionDB.Close();
            }
        }

        /// <summary>
        /// Permet la mise à jour des informations d'une activité.
        /// </summary>
        /// <param name="uneActivite">objet Activite</param>
        public static void UpdateActivite(Activite uneActivite)
        {
            try { 
            DBManager.ConnexionDB.Open();
            SqlCommand req = new SqlCommand("UPDATE Activite SET nom = @nom,  NbPlaces = @NbPlaces, prix = @prix, dateActivite = @dateActivite, estMatin = @estMatin WHERE id = @id", DBManager.ConnexionDB);
            req.Parameters.AddWithValue("@nom", uneActivite.Nom);
            req.Parameters.AddWithValue("@NbPlaces", uneActivite.NbPlaces);
            req.Parameters.AddWithValue("@prix", uneActivite.Prix);
            req.Parameters.AddWithValue("@dateActivite", uneActivite.DateActivite);
            req.Parameters.AddWithValue("@estMatin", uneActivite.EstMatin);
            req.Parameters.AddWithValue("@id", uneActivite.Id);
            req.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
        }
        
        /// <summary>
        /// Supprime une Activite de la base de données.
        /// </summary>
        /// <param name="uneActivite">l'activité que l'on souhaite supprimer.</param>
        public static void DeleteActivite(Activite uneActivite)
        {
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("DELETE FROM Activite WHERE id = @id", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@id", uneActivite.Id);
                req.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

        }

        /// <summary>
        /// Ajoute un congressiste à une Activite.
        /// </summary>
        /// <param name="uneActivite">l'activité où l'on souhaite ajouter le congressiste</param>
        /// <param name="unCongressiste">Le congressiste que l'on souhaite ajouter</param>
        public static void AddParticipant(Activite uneActivite, Congressiste unCongressiste)
        {
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("INSERT INTO PARTICIPER(idCongressiste,idActivite) VALUES(@idCongressiste,@idActivite)", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idCongressiste", unCongressiste.Id);
                req.Parameters.AddWithValue("@idActivite", uneActivite.Id);
                req.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
        }

        /// <summary>
        /// Obtient une liste de tout les congressistes ne participant pas à l'activité.
        /// </summary>
        /// <param name="uneActivite">L'activite où l'on souhaite connaître les non-participants</param>
        /// <returns>Liste des congressistes non-participants.</returns>
        public static List<Congressiste> GetCongressistesNonParticipants(Activite uneActivite)
        {
            List<Congressiste> congressistes = new List<Congressiste>();
            try
            {
                DBManager.ConnexionDB.Open();
                //Requête avec un Not Exists et sans étoile dans la sous-requête
                SqlCommand req = new SqlCommand("SELECT c.id,c.nom,c.prenom,c.tel,c.adresse,c.cp,c.ville,c.accompte,c.idLigue,c.idHebergement " +
                                                "FROM Congressiste c " +
                                                "WHERE NOT EXISTS (SELECT p.idCongressiste FROM PARTICIPER p WHERE p.idCongressiste = c.id AND p.idActivite = @idActivite)", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idActivite", uneActivite.Id);
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
        /// Supprime un participant d'une Activite dans la base de données.
        /// </summary>
        /// <param name="uneActivite"></param>
        /// <param name="unCongressiste"></param>
        public static void DeleteParticipant(Activite uneActivite, Congressiste unCongressiste)
        {
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("DELETE FROM PARTICIPER WHERE idCongressiste = @idCongressiste AND idActivite = @idActivite", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idCongressiste", unCongressiste.Id);
                req.Parameters.AddWithValue("@idActivite", uneActivite.Id);
                req.ExecuteNonQuery();
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
        }

        public static int GetPlacesRestantes(Activite uneActivite)
        {
            int placesRestantes = 0;
            try
            {
                DBManager.ConnexionDB.Open();
                SqlCommand req = new SqlCommand("exec nbPlacesDispoActivite @idActivite", DBManager.ConnexionDB);
                req.Parameters.AddWithValue("@idActivite", uneActivite.Id);
                placesRestantes = Convert.ToInt32(req.ExecuteScalar());
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return placesRestantes;
        }
    }
}
