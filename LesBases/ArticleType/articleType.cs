struct ArticleType
{
    public string nom;
    public double prix;
    public int quantite;
    public Type type;
    public enum Type { Alimentaire, Droguerie, Habillement, Loisir, Autre };

    public ArticleType(string nom, double prix, int quantite, Type type)
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
}