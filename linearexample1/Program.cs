using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearexample1
{
    class Program
    {
        //array to be seacrhed
        int[] arr = new int[20];
        //number of element in the array
        int n;
        //get the number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 element.\n");
            }
            //accept array element
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter Array Element ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = int.Parse(s1);
            }
              
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                // accept the number to be searched
                Console.Write("\nEnter the element you want to seacrh :");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary seacrh
                int lowerbound = 0;
                int upperbound = 0;

                //obtain the index of the middle element
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                // loop to search for the element in the array
                while ((item != arr[mid]) && (ctr <= upperbound))
                {
                    if (item == arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.Write("\nContinue search (y/n): ");
                ch = char.Parse(Console.ReadLine().ToUpper());

            } while ((ch == 'y'));
        }

        public void LinearSearch()
        {
            char ch;
            // search for the number of comparison
            int ctr;
            do
            {
                //accept the number to be seacrhed
                Console.Write("\nEnter the element you want to search: ");
                int item = Convert.ToInt32((Console.ReadLine()));

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " found st position " + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array");
                Console.WriteLine("\nNumber of comparison: " + ctr);
                Console.WriteLine("\nContinue search (y/n): ");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("=================");
                    Console.WriteLine("1. linear seacrh");
                    Console.WriteLine("2. binary seacrh");
                    Console.WriteLine("3. exit");
                    Console.WriteLine("Enter your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("...................");
                            Console.WriteLine("Linear Search ");
                            Console.WriteLine("...................");
                            myList.input();
                            myList.LinearSearch();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("...................");
                            Console.WriteLine("Binary Search ");
                            Console.WriteLine("...................");
                            myList.input();
                            myList.BinarySearch();
                            break;
                        case 3:
                            Console.WriteLine("Exit");
                            break;
                    }
                    Console.WriteLine("\nPilih menu lagi? (y/n): ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                //to exit from the console
                Console.WriteLine("\n\nPress return to exit.");
                Console.ReadLine();
            }while(pilihanmenu != 3);
        }
    }
}
