class Program
{
    static void Main(string[] args)
    {
        List<Article> articles = new List<Article> {
            new Livre("Livre A", 20, 10, Article.Type.Autre, "123456789", 300),
            new Disque("Disque B", 15, 5, Article.Type.Autre, "Label XYZ"),
            new Video("Video C", 30, 2, Article.Type.Loisir, 120),
            new Poche("Livre Poche", 10, 20, Article.Type.Autre, "987654321", 150, "Fiction"),
            new Broche("Livre Broché", 25, 8, Article.Type.Autre, "1122334455", 400, "Policier")
        };

        foreach (var article in articles)
        {
            Console.WriteLine("Coût de location de {0}", article.CalculateRent());
            article.PublishDetails();
        }
    }
}