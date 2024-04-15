using DataWriter.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWriter.metier
{
    internal class Transformations
    {
        internal static void TransformMaj(RegistreArticles listing)
        {
            foreach (Article article in listing.Registre)
            {
                article.Description = article.Description.ToUpper();
            }
        }

        internal static void TransformPrix(RegistreArticles listing, int min, double rabais)
        {
            foreach (Article article in listing.Registre)
            {
                if (article.Quantity < min)
                {
                    article.Price = article.Price * (1 - rabais);
                }
            }
        }
    }
}
