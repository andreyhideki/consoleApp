using ConsoleApp1.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        //arrayFirstOrDefault();

        //imprime("aeeeeeeeeee");

        var products = listProducts();

        groupByExample(products);
        
        selectExample(products);

    }

    private static void selectExample(List<Product> products)
    {
        var resultSelect = products
                    .Select(sel => new { sel.Name, sel.Id, sel.Price });

        foreach (var p in resultSelect)
        {
            Console.WriteLine(p.ToString());
        }
    }

    private static void groupByExample(List<Product> products)
    {
        var resultGroup = from p in products
                          group p by p.Status into pAgrupado
                          select pAgrupado.Key;

        foreach (var p in resultGroup)
        {
            Console.WriteLine(p.ToString());
        }
    }

    private static List<Product> listProducts()
    {
        var listaCategories = new List<Category>();
        listaCategories.Add(new Category(1, "Eletro"));
        listaCategories.Add(new Category(2, "Notebook"));
        listaCategories.Add(new Category(3, "Printer"));

        var listProducts = new List<Product>();
        listProducts.Add(new Product(1, "TV", "TV", 10, 1, true));
        listProducts.Add(new Product(2, "Radio", "Radio", 20, 1, false));
        listProducts.Add(new Product(3, "Notebook", "Notebook", 30, 2, true));
        listProducts.Add(new Product(4, "HP", "HP", 10, 3, true));
        listProducts.Add(new Product(5, "BROTHER", "BROTHER", 20, 3, false));

        return listProducts;
    }

    private static void arrayFirstOrDefault()
    {
        int[] arr = { 1, 2, 2, 3, 5, 9, 10 };

        Console.WriteLine(arr.FirstOrDefault(99));
    }

    public static void imprime(string texto)
    {
        Console.WriteLine(texto);
    }
}