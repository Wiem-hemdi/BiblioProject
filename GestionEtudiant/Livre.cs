using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionLivre
{
    public class Livre
    {
        public int Id { get; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Disponible { get; set; }  


        private static int _idCourant = 1;

        public Livre(string titre, string auteur, string disponible)
        {
            Id = _idCourant++;
            Titre = titre;
            Auteur = auteur;
            Disponible = disponible;

        }
    }
}
