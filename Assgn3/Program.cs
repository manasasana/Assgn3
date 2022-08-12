/*Write a program in C# Sharp to append some text to an existing file.
public class TestGeneric
{
    public static void Main(string[] args)
    {
        


        FileStream fileStream = new FileStream("C:\\testing\\example.txt", FileMode.Open);
        StreamWriter sw = new StreamWriter(fileStream);
        sw.WriteLine("written into file");
  
        sw.Close();
        fileStream.Close();
        Console.WriteLine("we created a file");
        
       
    }
}
2.Write a program in C# Sharp to create a file and move the file into the same directory to another name.


Write a program in C# Sharp to create a list with StudentID and StudentMarks as key value pair; use any suitable collection. 
Display the list on the screen
using System;
using System.IO;
public class SimpleFileMove
{
    static void Main()
    {

        string sfileName = @"example1.txt";
        string tfileName = @"example2.txt";
        using (StreamWriter fileStr = File.CreateText(sfileName))
        {
            fileStr.WriteLine(" Hello and Welcome");
            fileStr.WriteLine(" It is the first content");
            fileStr.WriteLine(" of the text file example1.txt");
        }
        using (StreamReader sr = File.OpenText(sfileName))
        {
            string s = "";
            Console.WriteLine(" Here is the content of the file {0} : ", sfileName);
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");
        }
        System.IO.File.Move(sfileName, tfileName); 
        Console.WriteLine(" The file {0} successfully moved to the name {1} in the same directory.", sfileName, tfileName);

        using (StreamReader sr = File.OpenText(tfileName))
        {
            string s = "";
            Console.WriteLine(" Here is the content of the file {0} : ", tfileName);
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");
        }
        Console.ReadKey();
    }
}

Write a program in C# Sharp to create a list with StudentID and StudentMarks as key value pair; use any suitable collection. 
Display the list on the screen

public class Simple
{
    static void Main()
    {
        SortedList<int, string> dict = new SortedList<int, string>();
        dict.Add(1, "manu");
        dict.Add(5, "nayan");
        dict.Add(9, "karan");
        dict.Add(4, "riya");
        foreach (KeyValuePair<int, string> kvp in dict)
            Console.WriteLine(kvp);
    }
}*/

/*The output should have list of IDs, Names and Pass Status of Students like [12, Rahul Y], [14, Kiran, N], etc.
 Write a C# program and use a Generic method to display the values; display atleast 5 students.
public class GenericList<T>
{
    public void Add(T input) { }
}
public class TestGenericList
{
    
    public static void Main()
    {
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(12);
            list1.Add(14);
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Rahul");
            list2.Add("Kiran");
            GenericList<char> list3 = new GenericList<char>();
            list3.Add('Y');
            list3.Add('N');
            foreach (int i in list1)
            {
                Console.Write(i + " ");
            }

        foreach (int i in list2)
        {
            Console.Write(i + " ");
        }
        foreach (int i in list3)
        {
            Console.Write(i + " ");
        }
    }
}