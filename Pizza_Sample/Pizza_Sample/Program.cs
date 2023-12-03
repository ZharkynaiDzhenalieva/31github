using System.Drawing;
using System.Linq;

namespace Pizza_Sample;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    }

    public static void LinQueries(IEnumerable<Pizza> pizzas)
    {
        //5.1 Query those pizzas that doesn't contain the word 'pizza'.
        var NoPizzaInName = pizzas.Where(pizza => !pizza.FantasyName.Contains("Pizza"));
        Console.WriteLine("5.1-----------------");
        foreach (var item in NoPizzaInName)
        {
            Console.WriteLine($"{item.FantasyName}");
        }
        /*5.2 Write a query that gets how many unique sizes are there,
        then sort these in descending order. (the output should be in
        an anonymus class with TYPE & COUNT fields)*/
        var NumberOfUniqueSizes = pizzas.GroupBy(pizza => pizza.Size).Select(pizza => new
        {
            Type = pizza.Key,
            Count = pizza.Count()
        }).OrderByDescending(x => x.Count);
        Console.WriteLine("5.2-------------------");
        foreach (var item in NumberOfUniqueSizes)
        {
            Console.WriteLine($"Type: {item.Type}, Number of Unique Sizes: {item.Count}");
        }
        /*5.3.1 Query those pizzas' names and types that contain atleast 4 toppings*/

        var AtLeast4Toppings = pizzas.Where(pizza => pizza.NumberOfToppings >= 4).Select(pizza => new {

            Name = pizza.FantasyName,
            Type = pizza.Type

        });
        Console.WriteLine("5.3.1---------"); 
        foreach (var item in AtLeast4Toppings)
        {
            Console.WriteLine($"Name: {item.Name}, Number of Toppings: {item.Type}");
        }
        /*5.3.2 Get the average price for each type.*/
        var AvgPrc = pizzas.GroupBy(pizza => pizza.Price).Select(pizza => new
        {
            Type = pizza.Key,
            Price = pizza.Average(pizza => pizza.Price),
        }) ;
        Console.WriteLine("5.3.2-----------");
        foreach (var item in AvgPrc)
        {
            Console.WriteLine($"Type: {item.Type}, Average price: {item.Price}");
        }
        /*5.4 Query the average price for each different size of pizza. 
         * (output class should be anonymus with SIZE and AVGSAL fields)*/
        var AvgPrice4DiffSizes = pizzas.GroupBy(pizza => pizza.Size).Select(pizza => new
        {
            Size = pizza.Key,
            AvgSal = pizza.Average(pizza => pizza.Price), 
        }) ;
        Console.WriteLine("5.4---------");
        foreach (var item in AvgPrice4DiffSizes)
        {
            Console.WriteLine($"Size: {item.Size}, Average price: {item.AvgSal}");
        }
        /*5.5 Determine that depending on type how many sizes are there*/
        var NumberofSizes = pizzas.GroupBy(pizza => pizza.Type).Select(pizza => new
        {
            Type = pizza.Key,
            Count = pizza.Select(pizza => pizza.Size).Distinct().Count(),
        });
        Console.WriteLine("5.5----------");
        foreach (var item in NumberofSizes)
        {
            Console.WriteLine($"Type: {item.Type}, Number of Sizes: {item.Count}");
        }
        /*5.6 Query those pizzas whose names' length is less than the sum of PastaThickness and 
          NumberOfToppings multiplied by 2.*/
        var LengthLessThanSum = pizzas.Where(pizza => pizza.FantasyName.Length <= 2 * (pizza.PastaThickness + pizza.NumberOfToppings));
        Console.WriteLine("5.6------------");
        foreach (var item in LengthLessThanSum)
        {
            Console.WriteLine($"Name: {item.FantasyName}, Length: {item.FantasyName.Length}");
        }

        //5.7 Determine that VIP or regular pizzas have more with the size of 30
        string isVip = "";
        var SizeOf30 = pizzas.Where(pizza => pizza.Size == 30).GroupBy(pizza => pizza.IsVIP).Select(pizza => new
        {
            IsVip = pizza.Key,
            Count = pizza.Count(),
        }).OrderByDescending(pizza => pizza.Count);
        if(SizeOf30.First().IsVip == true)
        {
            isVip = "VIP";
        }
        else
        {
            isVip = "Regular";
        }
        Console.WriteLine("5.7-------------");
        foreach (var item in SizeOf30)
        {
            Console.WriteLine($"Status: {item.IsVip}, Number of pizzas with the size of 30: {item.Count}");
        }
        /*5.8 Determine that VIP or regular pizzas have longer than average names*/
        string isVip2 = "";
        var LngThanAvg = pizzas.GroupBy(pizza => pizza.IsVIP).Select(pizza => new
        {
            IsVip = pizza.Key,
            Average = pizza.Average(pizza => pizza.FantasyName.Length),

        }).OrderByDescending(pizza => pizza.Average);

        if (LngThanAvg.First().IsVip == true)
        {
            isVip2 = "VIP";
        }
        else
        {
            isVip2 = "Regular";
        }
        Console.WriteLine("5.8-----------");
        foreach (var item in LngThanAvg)
        {
            Console.WriteLine($"Status: {item.IsVip}, Average length of the name: {item.Average}");
        }
        Console.ReadKey();

    }
}

