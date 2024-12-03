class Article
{
    public string designation;
    public double prix;

    public void acheter()
    {
        Console.WriteLine("Achat de l'article " + designation + " (" + prix + " euros)");
    }
}