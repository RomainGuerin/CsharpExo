public delegate double DiscountStrategy(Article article);

public class DiscountStrategies
{
    public static double PourcentageFixe(Article article)
    {
        return article.prix * 0.9;
    }
    public static double PourcentageTypeArticle(Article article)
    {
        switch (article.type)
        {
            case Article.Type.Alimentaire:
                return article.prix * 0.95;
            case Article.Type.Droguerie:
                return article.prix * 0.8;
            case Article.Type.Habillement:
                return article.prix * 0.7;
            case Article.Type.Loisir:
                return article.prix * 0.85;
            case Article.Type.Autre:
                return article.prix * 0.9;
            default:
                return article.prix;
        }
    }
}

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

        DiscountStrategy discountStrategy = DiscountStrategies.PourcentageFixe;
        DiscountStrategy discountStrategyType = DiscountStrategies.PourcentageTypeArticle;

        foreach (var article in articles)
        {
            Console.WriteLine("Article : {0}", article.nom);
            Console.WriteLine("Coût de location de {0}", article.CalculateRent());
            article.PublishDetails();
            Console.WriteLine("Coût de location avec réduction de {0}", discountStrategy(article));
            Console.WriteLine("Coût de location avec réduction de {0} pour le type d'article", discountStrategyType(article));
        }
    }
}