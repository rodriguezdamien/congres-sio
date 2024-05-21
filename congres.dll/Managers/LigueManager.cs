﻿using System;
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
    }
}
