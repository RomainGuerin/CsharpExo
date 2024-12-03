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
}