﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll
{
    public class Congressiste
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Congressiste() { }

        /// <summary>
        /// Constructeur de Congressiste avec tout ses attributs
        /// </summary>
        /// <param name="id">Id du congressiste</param>
        /// <param name="nom">Nom du congressiste</param>
        /// <param name="prenom">Prenom du congressiste</param>
        /// <param name="tel">Tel du congressiste</param>
        /// <param name="adresse">Adresse du congressiste</param>
        /// <param name="cp">Code postal du congressiste</param>
        /// <param name="ville">Ville du congressiste</param>
        /// <param name="accompte">Accompte du congressiste</param>
        /// <param name="idLigue">Clé étrangère IdLigue du congressiste</param>
        /// <param name="idHebergement">Clé étrangère IdHebergement du congressiste</param>
        public Congressiste(int id, string nom, string prenom, string tel = "", string adresse = "", string cp = "", string ville = "", decimal accompte = 0,double restantDu = 0d, double montantTotal = 0d, int idLigue = 0, int? idHebergement = null)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Adresse = adresse;
            this.Cp = cp;
            this.Ville = ville;
            this.Accompte = accompte;
            this.RestantDu = restantDu;
            this.montantTotal = montantTotal;
            this.IdLigue = idLigue;
            this.IdHebergement = idHebergement;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Adresse { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        //conversion de float à double
        public decimal Accompte { get; set; }
        public double RestantDu { get; set; }
        public double montantTotal { get; set; }
        public int IdLigue { get; set; }
        public Ligue laLigue { get; set; }
        public int? IdHebergement { get; set; }
        public Hebergement sonHebergement { get; set; }
        public List<Session> SessionsInscrit { get; set; }
        public List<Activite> ActivitesInscrit { get; set; }

    }
}
