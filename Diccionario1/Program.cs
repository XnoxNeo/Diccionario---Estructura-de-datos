using Diccionario1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static Dictionary<string, Clients> dictionary = new Dictionary<string, Clients>();
    private static void Main(string[] args)
    {



        LoadClients();


        while(true)
        {
            Console.WriteLine("Type a number to select an option:\n 1 - Add a client \n 2 - Show current clients \n 3 - Finish");
            
            string chosenOption = Console.ReadLine();


            switch(chosenOption)
            {
                case "1":
                    AddClient();

                    break;

                case "2":
                    ShowClients();
                    
                    break;



                case "3":

                    return;

                default:
                    Console.WriteLine("Choose again");
                    break;
            }
        }
        

        









    }

    private static void ShowClients()
    {
        Console.WriteLine("These are all the clients: ");

        foreach (var client in dictionary.Values)
        {
            Console.WriteLine($"Name: {client.name} {client.surname}, Phone:{client.phone}, Total spent:{client.totalSpent}, Purchases: {client.purchases}");
        }


    }

    private static void AddClient()
    {

        Console.WriteLine("DNI: ");
        string document = Console.ReadLine();
            
        if(dictionary.ContainsKey(document))
        {
            Console.WriteLine("Existing client");
            Console.WriteLine("Looks like we doin purchases now");
            var exisitingClient = dictionary[document];
            exisitingClient.purchases++;
        }
        else
        {
            Console.Write("Name:  ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Phone: "); 
            string phone = Console.ReadLine();

            Console.Write("TotalSpent: ");
            float totalSpent;

            while (!float.TryParse(Console.ReadLine(), out totalSpent))
            {
                Console.Write("Write that again pls: ");
            }

          
            dictionary.Add(document, new Clients(name, surname, phone, totalSpent, 1));
        }


    }

    private static void LoadClients()
    {
        dictionary.Add("46005582", new Clients("Mariano", "Blanco", "1100001111", 100f, 2));
    }



}