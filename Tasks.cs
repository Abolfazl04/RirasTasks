using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace RirasTasks
{
    internal class Tasks
    {
        //This file is used to calculate and output the tasks results 
        
        
        public static void T1(List<Product> products)
        {
            //This line searches through the list and finds every Product that is in Category1 
            //then saves them inside "Results" 
            var Results = products.Where(c => c.Category == Categories.Category1);    
            
            //Outputting the results 
            foreach (var i in Results)
            {
                Console.WriteLine(i.Name);
            }
        }

        public static void T2(List<Product> products)
        {
            //Using .Max can find the highest value in a list so we can find the highest price 
            decimal MostExpensive =(products.Max(x => x.Price));
            //Outputting the founded Product
            Console.WriteLine("The most expensive product is : " + MostExpensive);
        }

        public static void T3(List<Product> products)
        {   
            //using .Sum we can find this Answer 
            double sum = Convert.ToDouble(products.Sum(x => x.Price));
            //Outputting the total sum of prices 
            Console.WriteLine("The total sum is : " + sum);
        }
        
        public static void T4(List<Product> products)
        {
            //I sorted the products by categories using .OrderBy 
            //It will not be necessary if used with the next lines but if we are just going to sort 
            //and not display them we have to use it 
            products = products.OrderBy(x => x.Category).ToList();
            
            //The first loop is to find every type of categories that we have 
            foreach (Categories category in Enum.GetValues(typeof(Categories))) 
            {
                Console.WriteLine(category + " :");
                //Inside the second loop every products category is being compared to the
                //category in first loop, if matched it will be outputted 
                foreach (var product in products)
                    if (product.Category == category)
                        Console.WriteLine(product.Name);
            }
        }
        public static void T5(List<Product> products)
        {
            //Using .Average we can easily find the average of the prices
            double avg = Convert.ToDouble(products.Average(x => x.Price));
            Console.WriteLine("Average Price is : " + avg);
        }
    }
}
