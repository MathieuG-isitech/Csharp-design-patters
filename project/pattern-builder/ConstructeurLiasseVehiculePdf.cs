namespace PatternBuilder
{
    public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            liasse = new LiassePdf();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = $"Bon de commande PDF pour {nomClient}";
            liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = $"Demande d'immatriculation PDF pour {nomDemandeur}";
            liasse.AjouteDocument(document);
        }
    }
}
