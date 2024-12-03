public interface IRentable
{
    double CalculateRent();
}

public abstract class Publication
{
    public abstract void PublishDetails();
}

public class Article : Publication, IRentable
{
    public string nom { get; set; }
    public double prix { get; set; }
    public int quantite { get; set; }
    public Type type { get; set; }
    public enum Type
    {
        Alimentaire, Droguerie, Habillement, Loisir, Autre
    };

    public Article(string nom, double prix, int quantite, Type type)
    {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
        this.type = type;
    }

    public void Afficher()
    {
        Console.WriteLine("Article : {0}, Prix : {1}, Quantité : {2}, Type : {3}", nom, prix, quantite, type);
    }

    public void Ajouter(int qte)
    {
        if (qte > 0)
        {
            quantite += qte;
        }
        else
        {
            Console.WriteLine("La quantité à ajouter doit être un nombre entier positif.");
        }
    }

    public void Retirer(int qte)
    {
        if (qte > 0 && qte <= quantite)
        {
            quantite -= qte;
        }
        else
        {
            Console.WriteLine("Quantité invalide.");
        }
    }

    public virtual double CalculateRent()
    {
        return this.prix * 0.99;
    }

    public override void PublishDetails()
    {
        Console.WriteLine("Article: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}", nom, prix, quantite, type);
    }
}