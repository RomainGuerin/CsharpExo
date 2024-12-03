class Disque : Article
{
    public string label;

    public void ecouter()
    {
        Console.WriteLine("Ecoute du disque " + label + " (" + designation + ")");
    }
}