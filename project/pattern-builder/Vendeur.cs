namespace PatternBuilder
{
    public class Vendeur
    {
        private ConstructeurLiasseVehicule constructeur;

        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            this.constructeur = constructeur;
        }

        public Liasse Construit(string nomClient, string nomDemandeur)
        {
            constructeur.ConstruitBonDeCommande(nomClient);
            constructeur.ConstruitDemandeImmatriculation(nomDemandeur);
            return constructeur.Resultat();
        }
    }
}
