using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        //System.Console.WriteLine("Enter colors");
        //string[] colors = { "Red", "Blue", "Green" };
        //int i = 0;
        //while (i < 3)

        //{
        //    colors[i] = System.Console.ReadLine(); // read the line and stores in array            //part 1
        //    i++;
        //}
        //System.Console.WriteLine("press any key to print words");
        //System.Console.ReadLine();
        //foreach (string item in colors)
        //{
        //    System.Console.WriteLine(item);  // print each item from the array
        //}
        //System.Console.ReadLine();




        //System.Console.WriteLine("Enter colors");
        //string[] colors = { "Red", "Blue", "Green" };
        //int i = 0;
        //while (i < 3)
        //{
        //    colors[i] = System.Console.ReadLine(); // read the line and stores in array         //part 2
        //}
        //System.Console.WriteLine("press any key to print words");
        //System.Console.ReadLine();
        //foreach (string item in colors)
        //{
        //    System.Console.WriteLine(item);  // print each item from the array
        //}
        //System.Console.ReadLine();




        //System.Console.WriteLine("Enter colors");
        //string[] colors = { "Red", "Blue", "Green" };
        //int i = 0;
        //while (i <= 3)
        //{
        //    colors[i] = System.Console.ReadLine(); // read the line and stores in array         //part 3
        //    i++;
        //}
        //System.Console.WriteLine("press any key to print words");
        //System.Console.ReadLine();
        //foreach (string item in colors)
        //{
        //    System.Console.WriteLine(item);  // print each item from the array
        //}
        //System.Console.ReadLine();




        //List<string> names = new List<string>() { "Bob, Josh, Jesse, Daniel, Adam" };
        //foreach (string name in names)
        //{

        //}






        //List<string> names = new List<string>() { "Josh", "Rachel", "Bob" };
        //bool isGuessed = false;
        //while (!isGuessed)
        //{
        //    Console.WriteLine("input text to search list");
        //    string x = Console.ReadLine();
        //    bool stringFound = false;
        //    int index = names.FindIndex(a => a.Contains(x));
        //    for (int s = 0; s < names.Count; s++)                                                 /part 4
        //    {
        //        if (names[s] == x)
        //        {
        //            Console.WriteLine("Index: " + index);
        //            stringFound = true;
        //            isGuessed = true;
        //        }
        //    }
        //    if (!stringFound)
        //    {
        //        Console.WriteLine("Search result not in the list");
        //    }
        //    Console.ReadLine();
        //}







        //List<string> names = new List<string>() { "Josh", "Bob", "Josh" };
        //bool isGuessed = false;
        //while (!isGuessed)
        //{
        //    Console.WriteLine("input text to search list");
        //    string x = Console.ReadLine();
        //    bool stringFound = false;
        //    int index = names.FindIndex(a => a.Contains(x));
        //    for (int s = 0; s < names.Count; s++)                                                 // part 5
        //    {
        //        if (names[s] == x)
        //        {
        //            Console.WriteLine("Index: " + index);
        //            stringFound = true;
        //            isGuessed = true;
        //        }
        //    }
        //    if (!stringFound)
        //    {
        //        Console.WriteLine("Search result not in the list");
        //    }
        //    Console.ReadLine();
        //}







        List<string> names = new List<string>() { "Josh", "Bob", "Josh", "Rachel" };       //first list
        List<string> dupenames = new List<string>();                                           //second list to use to check for dupes    
        foreach (string name in names)
        {
            if (dupenames.Contains(name))                         //if duplicate 
            {
                Console.WriteLine(name + ": has already appeared in list.");                                  //part 6
            }
            else
            {
                dupenames.Add(name);                  //if no duplicate
                Console.WriteLine(name + ": has not appeared in the list.");
            }

        }
        Console.ReadLine();














    }
}

