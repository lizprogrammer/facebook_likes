using System;
using System.Collections.Generic;

public class Person
{
    // Constructor that takes no arguments:
    public Person()
    {
        Name = "unknown";
    }

    // Constructor that takes one argument:
    public Person(string name)
    {
        Name = name;
    }

    // Auto-implemented readonly property:
    public string Name { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }
}
class TestPerson
{
    static void Main()
    {
        // Call the constructor that has no parameters.
        
        List<Person> MyLikes = new List<Person>();
        
        while(true)
        {
            Console.Write("Enter a name: ");    
            var name = Console.ReadLine();
            if((name == "end") || (name == ""))
                break;
            var liker = new Person(name);
            // Console.WriteLine(person2.Name);
            MyLikes.Add(liker);
        }
        
        if(MyLikes.Count == 1)
        {
            Console.WriteLine(String.Format("You have {0} like!", MyLikes.Count));
        }
        else if ((MyLikes.Count == 2)||(MyLikes.Count ==3))
        {
            Console.WriteLine(String.Format("You have {0} likes!", MyLikes.Count));
        }
        
  
        // Get the string representation of the person2 instance.
        // Console.WriteLine(person2);
        
            int more = MyLikes.Count - 2;
        
            if(MyLikes.Count == 0)
                Console.Write("You have no likes");
            // One like
            else if(MyLikes.Count == 1)
            {
                Console.Write(String.Format("{0} likes your post", MyLikes[0]));
            }
            // Two likes
            else if(MyLikes.Count == 2)
            {
                Console.Write(String.Format("{0} and {1} like your post", MyLikes[0], MyLikes[1]));
            }
            // More than two
            else
            {
                Console.Write(String.Format("{0}, {1} and {2} more like your post", MyLikes[0], MyLikes[1], more));
            }
            
            // Three likes
            
            // Greater than three likes
            
        
    

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}