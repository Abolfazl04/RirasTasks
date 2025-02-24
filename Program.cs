using System.Threading.Tasks;
using static System.Environment;
using RirasTasks;
//Creating an enum for categories as asked 
public enum Categories
{
    Category1,
    Category2,
    Category3
}

//Creating a class for our Products so we can save and access them easily 
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Categories Category { get; set; }
    public decimal Price { get; set; }
}

public class Program1
{
    public static void Main()
    {
        //The given piece of code that creates a list of "Product" called "products"
        List<Product> products = new List<Product>
                {
                    new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
                    new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
                    new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
                    new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
                    new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
                };

        //I used this space to call my functions that are in "Tasks.cs" and output the results
        Console.WriteLine(NewLine + "Task one : ");
        Tasks.T1(products);

        Console.WriteLine("-----------------" + NewLine + "Task Two : ");
        Tasks.T2(products);

        Console.WriteLine("-----------------" + NewLine + "Task Three : ");
        Tasks.T3(products);

        Console.WriteLine("-----------------" + NewLine + "Task Four : ");
        Tasks.T4(products);

        Console.WriteLine("-----------------" + NewLine + "Task Five : ");
        Tasks.T5(products);

    }





}
