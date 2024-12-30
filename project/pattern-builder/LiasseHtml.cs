namespace PatternBuilder
{
    public class LiasseHtml : Liasse
    {
        public override void Imprime()
        {
            Console.WriteLine("Impression de la liasse HTML :");
            foreach (string document in documents)
            {
                Console.WriteLine(document);
            }
        }
    }
}
