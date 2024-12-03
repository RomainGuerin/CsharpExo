using System;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

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
        List<Article> articles = new List<Article>
        {
            new Article("Pomme", 2.5, 50, Article.Type.Alimentaire),
            new Article("Savon", 3.2, 30, Article.Type.Droguerie),
            new Article("T-shirt", 15.0, 20, Article.Type.Habillement)
        };

        // 2/1 -- Requêtes LINQ de base :
        // Lister tous les articles appartenant à un type spécifique (ex. "Alimentaire").
        var alimentaires = from article in articles
                           where article.type == Article.Type.Alimentaire
                           select article;

        Console.WriteLine("Articles alimentaires :");
        foreach (var article in alimentaires)
        {
            article.Afficher();
        }

        // Trier les articles par prix décroissant.
        var articlesTries = from article in articles
                            orderby article.prix descending
                            select article;

        Console.WriteLine("Articles triés par prix décroissant :");
        foreach (var article in articlesTries)
        {
            article.Afficher();
        }

        // Calculer le stock total pour tous les articles
        var stockTotal = articles.Sum(article => article.quantite);
        Console.WriteLine("Stock total des articls: {0}", stockTotal);

        // 2/2 -- Filtrage avancé avec l’opérateur OfType :
        // Créez une liste contenant à la fois des objets Article et d’autres objets quelconques.
        List<object> mixedList = new List<object>
        {
            5.5,
            new Article("Pomme", 2.5, 50, Article.Type.Alimentaire),
            new Article("Savon", 3.2, 30, Article.Type.Droguerie),
            "Hello Virginie",
            new Article("T-shirt", 15.0, 20, Article.Type.Habillement),
            "Hello World",
            42
        };

        // Utilisez l’opérateur OfType<ArticleTypé>() pour extraire uniquement les articles typés de cette collection
        var articlesTypes = mixedList.OfType<Article>();
        Console.WriteLine("Articles typés :");
        foreach (var article in articlesTypes)
        {
            article.Afficher();
        }

        // 2/3 -- Projection avec des types anonymes :
        // Créez une vue simplifiée de vos articles en ne conservant que le nom et le prix sous forme de type anonyme.
        var articlesSimplifies = from article in articles
                                 select new { Nom = article.nom, Prix = article.prix };

        // Affichez ces types anonymes dans la console
        Console.WriteLine("Articles simplifiés :");
        foreach (var article in articlesSimplifies)
        {
            Console.WriteLine("Nom : {0}, Prix : {1}", article.Nom, article.Prix);
        }

        // 3/1 Méthodes d’extension personnalisées :
        // Utilisez cette méthode sur la liste d’articles pour tester son fonctionnement.
        Console.WriteLine("Articles :");
        ProgramExtensions.AfficherTous(articles);

        // 3/2 Expressions lambda pour les calculs :
        // Utilisez une expression lambda pour calculer la valeur totale du stock de tous les articles
        var valeurTotale = articles.Sum(article => article.prix * article.quantite);
        Console.WriteLine("Valeur totale du stock : {0}", valeurTotale);

        // 4/1 Sérialisation JSON :
        // Exportez votre liste d’articles vers un fichier JSON à l’aide de la bibliothèque System.Text.Json.
        var json = JsonSerializer.Serialize(articles);
        File.WriteAllText("articles.json", json);

        // 4/2 Désérialisation JSON :
        // Chargez les articles depuis le fichier JSON et affichez-les
        var jsonFromFile = File.ReadAllText("articles.json");
        List<Article> articlesFromJson = JsonSerializer.Deserialize<List<Article>>(jsonFromFile);
        Console.WriteLine("Articles depuis JSON :");
        ProgramExtensions.AfficherTous(articlesFromJson);
    }
}

// 3/1 Méthodes d’extension personnalisées :
public static class ProgramExtensions
{
    // Implémentez une méthode d'extension AfficherTous() permettant d'afficher dans la console tous les articles d’une liste avec leurs détails.
    public static void AfficherTous(this List<Article> articles)
    {
        foreach (var article in articles)
        {
            article.Afficher();
        }
    }
}