using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congres.dll
{
    public class Salle
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public List<Session> LesSessions { get; set; }

        /// <summary>
        /// Constructeur de la classe Salle
        /// </summary>
        /// <param name="id">Id de la salle </param>
        /// <param name="libelle">Nom de la salle </param>
        public Salle(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public override string ToString()
        {
            return this.Libelle;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Salle() { }
    }
}
