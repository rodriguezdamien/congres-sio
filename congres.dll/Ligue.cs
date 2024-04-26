using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll
{
    public class Ligue
    {
        public int Id { get; set; }
        public string Nom {get; set;}
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }

        /**<summary> Constructeur de Ligue avec tout ses attributs </summary>
         * <param name="id"> Id de la ligue </param>
         * <param name="nomLigue"> Nom de la ligue </param>
         * <param name="adresse"> Adresse de la ligue </param>
         * <param name="codePostal"> Code postal de la ligue </param>
         * <param name="ville"> Ville de la ligue </param>
         **/
        public Ligue(int id, string nomLigue, string adresse, string codePostal, string ville)
        {
            this.Id = id;
            this.Nom = nomLigue;
            this.Adresse = adresse;
            this.CodePostal = codePostal;
            this.Ville = ville;
        }


    }
}
