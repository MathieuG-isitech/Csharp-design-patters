namespace PatternBuilder
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse liasse; // composition : mecanisme qui permet à une classe de contenir une instance de cette même classe ou d'une autre

        public abstract void ConstruitBonDeCommande(string nomClient);
        public abstract void ConstruitDemandeImmatriculation(string nomDemandeur);

        public Liasse Resultat()
        {
            return liasse;
        }
    }
}
