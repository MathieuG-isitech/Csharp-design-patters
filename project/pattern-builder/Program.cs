using System;
using PatternBuilder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choisissez le format de la liasse (HTML ou PDF) :");
        string choix = Console.ReadLine()?.ToUpper();

        ConstructeurLiasseVehicule constructeur;
        if (choix == "HTML")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
        }

        Vendeur vendeur = new Vendeur(constructeur);
        Liasse liasse = vendeur.Construit("Client Mbappe", "Demandeur Zidane");
        liasse.Imprime();
    }
}
