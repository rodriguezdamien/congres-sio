using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll
{
    public class Hebergement
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        public string Tel { get; set; }
        public string NbEtoiles { get; set; }
        public decimal Prix { get; set; }
        public List<Congressiste> LesCongressistes { get; set; }

        /// <summary>
        /// Constructeur de Hebergement avec tout ses attributs
        /// </summary>
        /// <param name="id">Id de l'hebergement</param>
        /// <param name="nom">Nom de l'hebergement</param>
        /// <param name="adresse">Adresse de l'hebergement</param>
        /// <param name="cp">Code postal de l'hebergement</param>
        /// <param name="ville">Ville de l'hebergement</param>
        /// <param name="tel">Telephone de l'hebergement</param>
        /// <param name="nbEtoiles">Nombre d'etoiles de l'hebergement</param>
        /// <param name="prix">Prix de l'hebergement</param>
        public Hebergement(int id, string nom, string adresse, string cp, string ville, string tel, string nbEtoiles, decimal prix)
        {
            this.Id = id;
            this.Nom = nom;
            this.Adresse = adresse;
            this.Cp = cp;
            this.Ville = ville;
            this.Tel = tel;
            this.NbEtoiles = nbEtoiles;
            this.Prix = prix;
            this.LesCongressistes = new List<Congressiste>();
        }
    }
}
