using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll.Managers
{
    public class CongressisteManager
    {
        /// <summary>
        /// Permet de récupérer la liste des conggressistes.
        /// </summary>
        /// <returns>Liste d'objet congressiste.</returns>
        public static List<Congressiste> GetCongressistes()
        {
            List<Congressiste> lesCongressistes = new List<Congressiste>();
            SqlCommand reqGet = new SqlCommand("SELECT id, nom, prenom, tel, adresse, cp, ville, accompte, idLigue, idHebergement FROM CONGRESSISTE", DBManager.ConnexionDB);
            SqlCommand reqProcedure = new SqlCommand("exec montantTotal @idC", DBManager.ConnexionDB);
            try
            {
                DBManager.ConnexionDB.Open();
                SqlDataReader reader = reqGet.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string tel = reader.GetString(3);
                    string adresse = reader.GetString(4);
                    string cp = reader.GetString(5);
                    string ville = reader.GetString(6);
                    decimal accompte = reader.GetDecimal(7);
                    int idLigue = reader.GetInt32(8);
                    int? idHebergement = null;

                    if (!reader.IsDBNull(9))
                    {
                        idHebergement = reader.GetInt32(9);

                    }

                    double montant = GetMontantARegler(id);

                    lesCongressistes.Add(new Congressiste(id, nom, prenom, tel, adresse, cp, ville, accompte, restantDu: montant, montantTotal: montant + (double)accompte, idLigue, idHebergement));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }
            return lesCongressistes;
        }

        /// <summary>
        /// Permet d'ajouter un congressiste.
        /// </summary>
        /// <param name="congressiste"></param>
        /// <returns>Retourne 'true' si l'ajout à fonctionner et 'false' si rien n'a été ajouté ou si une erreur à été levé.</returns>
        public static int AddCongressiste(Congressiste congressiste)
        {
            object id;

            SqlCommand reqAdd = new SqlCommand("INSERT INTO CONGRESSISTE (nom, prenom, tel, adresse, cp, ville, accompte, idLigue, idHebergement) VALUES (@n, @p, @t, @a, @cp, @v, @accompte, @idL, @idH)", DBManager.ConnexionDB);
            reqAdd.Parameters.AddWithValue("@id", congressiste.Id);
            reqAdd.Parameters.AddWithValue("@n", congressiste.Nom);
            reqAdd.Parameters.AddWithValue("@p", congressiste.Prenom);
            reqAdd.Parameters.AddWithValue("@t", congressiste.Tel);
            reqAdd.Parameters.AddWithValue("@a", congressiste.Adresse);
            reqAdd.Parameters.AddWithValue("@cp", congressiste.Cp);
            reqAdd.Parameters.AddWithValue("@v", congressiste.Ville);
            reqAdd.Parameters.AddWithValue("@accompte", congressiste.Accompte);
            reqAdd.Parameters.AddWithValue("@idL", congressiste.IdLigue);

            SqlCommand reqGetId = new SqlCommand("SELECT @@IDENTITY", DBManager.ConnexionDB);

            if (congressiste.IdHebergement == null)
                reqAdd.Parameters.AddWithValue("@idH", DBNull.Value);
            else
                reqAdd.Parameters.AddWithValue("@idH", congressiste.IdHebergement);

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
        /// Permet de modifié les informations d'un congressiste.
        /// </summary>
        /// <param name="congressiste">Objet Congressiste.</param>
        /// <returns>Retourne 'true' si la modification à fonctionner et 'false' si rien n'a été modifié ou si une erreur à été levé.</returns>
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
            reqUdpt.Parameters.AddWithValue("@idL", congressiste.IdLigue);

            if (congressiste.IdHebergement == 0)
            {
                reqUdpt.Parameters.AddWithValue("@idH", DBNull.Value);
            }
            else
            {

                reqUdpt.Parameters.AddWithValue("@idH", congressiste.sonHebergement.Id);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idC">Id du congressiste à supprimer</param>
        /// <returns></returns>
        public static bool DelCongressiste(int idC)
        {
            bool isDel = false;

            SqlCommand reqDel = new SqlCommand("DELETE CONGRESSISTE WHERE id = @id", DBManager.ConnexionDB);
            reqDel.Parameters.AddWithValue("@id", idC);

            try
            {
                DBManager.ConnexionDB.Open();
                int ligneDel = reqDel.ExecuteNonQuery();
                //if simplifié
                if (ligneDel > 0) isDel = true;
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return isDel;
        }

        private static double GetMontantARegler(int idCongressiste)
        {
            double montant;
            SqlConnection conn = new SqlConnection(DBManager.ConnexionDB.ConnectionString);
            SqlCommand cmdGetMontant = new SqlCommand("exec montantTotal @idC", conn);
            try
            {
                conn.Open();
                cmdGetMontant.Parameters.AddWithValue("@idC", idCongressiste);
                var result = cmdGetMontant.ExecuteScalar();
                montant = Convert.ToDouble(result);
            }
            finally { conn.Close(); }

            return montant;
        }

        /// <summary>
        /// Récupération de toute les sessions auxquelles un congressiste participe.
        /// </summary>
        /// <param name="idC">id du congressiste</param>
        /// <returns>Liste des sessions</returns>
        public static List<Session> GetSessionsInscrit(int idC)
        {
            List<Session> sessionList = new List<Session>();

            SqlCommand reqGet = new SqlCommand("SELECT id, theme, nomPresident, NbPlaces, salle, prix, dateSession, estMatin FROM INSCRIRE I " +
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

        public static List<Activite> GetActivitesInscrit(int idC)
        {
            List<Activite> ActiviteList = new List<Activite>();

            SqlCommand reqGet = new SqlCommand("SELECT id,nom,NbPlaces,prix,dateActivite,estMatin FROM Participer P " +
                "                               JOIN ACTIVITE A on P.idActivite = A.id" +
                "                               WHERE idCongressiste = @idC;", DBManager.ConnexionDB);
            reqGet.Parameters.AddWithValue("@idC", idC);

            try
            {
                DBManager.ConnexionDB.Open();
                SqlDataReader reader = reqGet.ExecuteReader();
                while (reader.Read())
                {
                    ActiviteList.Add(new Activite(id: reader.GetInt32(0),
                                             nom: reader.GetString(1),
                                             nbPlaces: reader.GetInt32(2),
                                             prix: reader.GetDecimal(3),
                                             dateActivite: reader.GetDateTime(4),
                                             estMatin: reader.GetBoolean(5)
                                             ));
                }
            }
            finally
            {
                DBManager.ConnexionDB.Close();
            }

            return ActiviteList;
        }
    }

        
}
