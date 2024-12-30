namespace PatternBuilder
{
    public class LiassePdf : Liasse
    {
        public override void Imprime()
        {
            Console.WriteLine("Impression de la liasse PDF :");
            foreach (string document in documents)
            {
                Console.WriteLine(document);
            }
        }
    }
}
