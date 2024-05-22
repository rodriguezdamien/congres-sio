using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll
{
     public class Activite
    {
        
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateActivite { get; set; }
        public int NbPlace { get; set; }
        public decimal Prix { get; set; }
        public bool EstMatin { get; set; }
        public string AffichageMomentJournee { get { return this.EstMatin ? "Matin" : "Après-midi"; } }
        public List<Congressiste> CongressisteParticipants { get; set; }
        /**<summary> Constructeur de Activite avec tout ses attributs </summary>
         * <param name="id"> Id de l'activite </param>
         * <param name="nom"> Nom de l'activite </param>
         * <param name="dateActivite"> Date de l'activite </param>
         * <param name="nbPlace"> Nombre de place de l'activite </param>
         * <param name="prix"> Prix de l'activite </param>
         * <param name="estMatin"> Booléen pour savoir si l'activite est le matin </param>
         **/
        public Activite(int id, string nom, DateTime dateActivite, int nbPlace, decimal prix, bool estMatin)
        {
            this.Id = id;
            this.Nom = nom;
            this.DateActivite = dateActivite;
            this.NbPlace = nbPlace;
            this.Prix = prix;
            this.EstMatin = estMatin;
        }

        public Activite()
        {

        }
     }
}
