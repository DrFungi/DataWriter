using DataWriter.io;
using DataWriter.metier;
using DataWriter.modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fichierEntree = "c:\\temp\\data.txt";
            string fichierSortie = "c:\\temp\\data.csv";
            RegistreArticles listing = new RegistreArticles();
            ManipFichier.LireFichier(fichierEntree, listing);
            //show the list
            listing.Afficher();
            //transform the list all descriptions to uppercase
            Transformations.TransformMaj(listing);
            // transform the list all products
            Console.WriteLine("Saisir la qte minime pour obtenir le rabais");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le rabais");
            double rabais = Convert.ToDouble(Console.ReadLine());
            Transformations.TransformPrix(listing, min, rabais);
            //show the list
            listing.Afficher();
            //write the list to a file
            ManipFichier.EcrireFichier(fichierSortie, listing);
        }
    }
}
