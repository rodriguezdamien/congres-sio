﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll
{
     public class Activite
    {
        
        //on aurait pu faire un héritage de session quand même
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateActivite { get; set; }
        public int NbPlaces { get; set; }
        public int NbPlacesRestantes { get; set; }
        public decimal Prix { get; set; }
        public bool EstMatin { get; set; }
        public string AffichageMomentJournee { get { return this.EstMatin ? "Matin" : "Après-midi"; } }
        public List<Congressiste> CongressisteParticipants { get; set; }
        /**<summary> Constructeur d'activité avec tout ses attributs </summary>
         * <param name="id"> Id de l'activite </param>
         * <param name="nom"> Nom de l'activite </param>
         * <param name="dateActivite"> Date de l'activite </param>
         * <param name="nbPlaces"> Nombre de place de l'activite </param>
         * <param name="prix"> Prix de l'activite </param>
         * <param name="estMatin"> Booléen pour savoir si l'activite est le matin </param>
         **/
        public Activite(int id, string nom, DateTime dateActivite, int nbPlaces, decimal prix, bool estMatin)
        {
            this.Id = id;
            this.Nom = nom;
            this.DateActivite = dateActivite;
            this.NbPlaces = nbPlaces;
            this.Prix = prix;
            this.EstMatin = estMatin;
        }

        public Activite()
        {
        }
     }
}
