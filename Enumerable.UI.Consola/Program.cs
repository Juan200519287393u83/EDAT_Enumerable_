internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine(" Enumerables ");
        Console.WriteLine("-------------------------------");

        #region Lista

        var lista = new List<string>
        {
            "Juan",
            "Fleny",
            "Jan",
            "Pania",
            "Jose",
            "Alex",
            "Dora",
            "Steve"
        };
        lista.Add("Gaby");
        //foreach (var nombre in lista)
        //  {
        //      Console.WriteLine(nombre);
        //  }
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }




        #endregion
        Console.ReadKey();



    }
}