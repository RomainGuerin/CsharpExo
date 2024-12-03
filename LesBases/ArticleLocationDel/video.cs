public class Video : Article
{
    public int duree { get; set; }
    public Video(string nom, double prix, int quantite, Type type, int duree)
     : base(nom, prix, quantite, type)
    {
        this.duree = duree;
    }

    public override double CalculateRent()
    {
        return this.prix * 0.8;
    }

    new public void Afficher()
    {
        Console.WriteLine("Afficher la vidéo : {0}, Durée : {1}", this.nom, this.duree);
    }

    public override void PublishDetails()
    {
        Console.WriteLine("Vidéo: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}, Durée : {4}", this.nom, this.prix, this.quantite, this.type, this.duree);
    }
}