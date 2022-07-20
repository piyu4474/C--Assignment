using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment_2
{
    internal class Program
    {
        class MyArray
        {
            static void Main(string[] args)
            {
                Console.WriteLine("*****ARRAY DIFFERENT METHODS*****");

                int i;
                int j;
                Console.WriteLine("\n ----------FIRST ARRAY----------");
                Console.WriteLine("\nEnter size of first array:");
                j = Convert.ToInt32(Console.ReadLine());
                string[] arr = new string[j];
                for(i= 0; i < j; i++)
                {
                    Console.Write("\nEnter any string:  ");
                    //Storing value in an array
                    arr[i] = Console.ReadLine();
                }
                Console.WriteLine("\n");
                Console.WriteLine("*****DISPLAY ARRAY DATA*****\n");

                //Printing the value on console
                for (i = 0; i < j; i++)
                {
                    Console.WriteLine("   First Array String: {0}", arr[i]);
                }
                // Sorting array  
                Console.WriteLine("\n*****SORT METHOD*****");

                Array.Sort(arr);
                Console.WriteLine("\nSorted array list: \n");
                // Displaying sorted array  
                for (i = 0; i < j; i++)
                {
                    Console.WriteLine("\t" + arr[i] + "\n");
                }

                // Reverse array  
                Console.WriteLine("*****REVERSE METHOD*****");

                Array.Reverse(arr);
                Console.WriteLine("\nReversed array list: \n");
                // Displaying sorted array  
                for (i = 0; i < j; i++)
                {
                    Console.WriteLine("\t" + arr[i] + "\n");
                }

                Console.WriteLine("\n ----------SECOND ARRAY----------");
                int k, l;
                Console.WriteLine("\nEnter size of second array:");
                l = Convert.ToInt32(Console.ReadLine());
                string[] arr2 = new string[j];
                for (k = 0; k < l; k++)
                {
                    Console.Write("\nEnter any string:  ");
                    //Storing value in an array
                    arr2[k] = Console.ReadLine();
                }
                Console.WriteLine("\n");
                Console.WriteLine("*****DISPLAY ARRAY DATA*****\n");

                //Printing the value on console
                for (k = 0; k < l; k++)
                {
                    Console.WriteLine("   Second Array String:\n {0}", arr2[k]);
                }

                //To check the two arrays are equals or not

                Console.WriteLine("*****Check The Two Array Are Equals Or Not*****");

                Console.WriteLine("\n" + arr.Equals(arr2));
                string[] arr3 = new string[arr.Length];

                //Copy first array into another array

                Console.WriteLine("*****Copy Frist Array Into This Array*****\n");

                Array.Copy(arr, arr3, arr.Length);
                for (int p = 0; p < arr.Length; p++)
                {
                    Console.WriteLine("   Copied Array Element:\n {0}", arr3[p]);
                }

                Console.WriteLine("*****ARRAY LIST DIFFERENT METHODS*****\n");

                ArrayList arrList = new ArrayList();
               
                // Adding elements to ArrayList
                arrList.Add("Black");
                arrList.Add("Pink");
                arrList.Add("Blue");
                arrList.Add("Red");
                arrList.Add("Voilet");

                Console.WriteLine("The elements of the ArrayList are:");
                foreach (object obj in arrList)
                {
                    Console.WriteLine(obj);
                }

                Console.WriteLine("Arry List Count : " + arrList.Count);
                Console.WriteLine("Array List Capacity : " + arrList.Capacity);

                // Inserting 3 elements at random index in the ArrayList
                arrList.Insert(2, "Dog");
                arrList.Insert(3, "Horse");
                arrList.Insert(6, "Cat");

                // Displaying the modified ArrayList
                Console.WriteLine("*****The ArrayList after Inserting elements*****\n");

                // Displaying the elements in ArrayList
                foreach (string str in arrList)
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}
