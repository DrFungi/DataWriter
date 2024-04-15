using DataWriter.modele;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWriter.io
{
    internal class ManipFichier
    {
        internal static void LireFichier(string fichier, modele.RegistreArticles listing)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(fichier);
                string data = reader.ReadLine();
                while (data != null)
                {
                    Article article = ParseLigne(data);
                    listing.Ajouter(article);
                    data = reader.ReadLine();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        internal static void EcrireFichier(string fichierSortie, RegistreArticles listing)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fichierSortie);
                foreach (Article article in listing.Registre)
                {
                    string ligne = FromerLigne(article);
                    writer.WriteLine(ligne);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        private static string FromerLigne(Article article)
        {
            return article.Description + "," + article.Quantity + "," + article.Price;
        }

        private static Article ParseLigne(string data)
        {
            CultureInfo culture = new CultureInfo("en-CA");
            string[] champs = data.Split();
            int quantity = int.Parse(champs[1]);
            double price = double.Parse(champs[2], culture);
            return new Article(champs[0], quantity, price);
        }
    }
}




