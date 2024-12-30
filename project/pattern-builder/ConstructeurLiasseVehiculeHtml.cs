namespace PatternBuilder
{
    public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml()
        {
            liasse = new LiasseHtml();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = $"Bon de commande HTML pour {nomClient}";
            liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = $"Demande d'immatriculation HTML pour {nomDemandeur}";
            liasse.AjouteDocument(document);
        }
    }
}
