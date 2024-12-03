class Video : Article
{
    public string duree;

    public void afficher()
    {
        Console.WriteLine("Vidéo " + designation + " (" + duree + ")");
    }
}