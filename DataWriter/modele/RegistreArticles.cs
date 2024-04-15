using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWriter.modele
{
    internal class RegistreArticles
    {
        public List<Article> Registre { get; set; }

        public RegistreArticles()
        {
            Registre = new List<Article>();
        }
        internal void Ajouter(Article article)
        {
            Registre.Add(article);
        }
        internal void Afficher()
        {
            Console.WriteLine("=======Liste d'articles en memoire======");
            foreach (Article article in Registre)
            {
                Console.WriteLine(article);
            }
            Console.WriteLine("=========================================");
        }
    }
}
