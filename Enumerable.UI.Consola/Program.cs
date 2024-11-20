internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===========================");
        Console.WriteLine("Enumerables");
        Console.WriteLine("===========================");

        #region Lista

        var lista = new List<string>
        {
            "Juan",
            "Ileny",
            "Jan",
            "Dania",
            "Jose",
            "Carlos",
            "Karla",
            "Zuri"
        };

        lista.Add("Sonia");

        //foreach (var nombre in lista)
        // {
        //     Console.WriteLine(nombre);
        // }

        lista.Order();

        for(int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        #endregion

        Console.ReadKey();

    }
}