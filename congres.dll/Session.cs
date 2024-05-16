    using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll
{
    public class Session
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string NomPresident { get; set; }
        public int NbPlace { get; set; }
        public string Salle { get; set; }
        public decimal Prix { get; set; }
        public DateTime DateSession { get; set; }
        public bool EstMatin { get; set; }
        public string AffichageMomentJournee { get { return this.EstMatin ? "Matin" : "Après-midi"; } }
        public List<Congressiste> CongressisteParticipants { get; set; }


        /**<summary> Constructeur de Session avec tout ses attributs </summary>
         * <param name="id"> Id de la session </param>
         * <param name="theme"> Theme de la session </param>
         * <param name="nomPresident"> Nom du président de la session </param>
         * <param name="nbPlace"> Nombre de place de la session </param>
         * <param name="salle"> Salle de la session </param>
         * <param name="prix"> Prix de la session </param>
         * <param name="dateSession"> Date de la session </param>
         * <param name="estMatin"> Booléen pour savoir si la session est le matin </param>
         **/
        public Session(int id, string theme, string nomPresident, int nbPlace, string salle, decimal prix, DateTime dateSession, bool estMatin)
        {
            this.Id = id;
            this.Theme = theme;
            this.NomPresident = nomPresident;
            this.NbPlace = nbPlace;
            this.Salle = salle;
            this.Prix = prix;
            this.DateSession = dateSession;
            this.EstMatin = estMatin;
        }
    }
}
