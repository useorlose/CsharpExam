using System;

class ArrayProgram
{
    static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));


    static void ChangeArray(string[] arr) => Array.Reverse(arr);

    static void ChangeArrayElements(string[] arr)
    {

        arr[0] = "Grandma";
        arr[1] = "Mother";
        arr[2] = "Sister";
    }

    static void Main()
    {
        try
        {


            string[] relations = { "Grandpa", "Grandma", "Father", "Mother", "Brother", "Sister", "Me" };

            Console.WriteLine("Before");
            DisplayArray(relations);
            Console.WriteLine();


            ChangeArray(relations);

            Console.WriteLine("After:");
            DisplayArray(relations);
            Console.WriteLine();
        }
        catch(Exception e)
        {
            Console.WriteLine("There is some error please check");
        }



    }
}