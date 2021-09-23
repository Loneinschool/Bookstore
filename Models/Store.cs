using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Store
    {
        public List<Newspaper> newsPapers = new List<Newspaper>();
        public List<Book> books = new List<Book>();
        public Store()
        {
            //Tilføjer aviser til butikken
            Newspaper politikken = new();
            politikken.Date = DateTime.Today;
            politikken.Id = 1;
            politikken.Pages = 34;
            politikken.Price = 30.50m;
            politikken.Publisher = "Politikken";
            politikken.Title = "Politikken";

            Newspaper bt = new()
            {
                Id = 2,
                Title = "BT",
                Date = DateTime.Today,
                Publisher = "BT",
                Pages = 60,
                Price = 10

            };

            Book harryPotter = new()
            {
                Id = 1,
                Isbn = 8700398365,
                Publisher = "Gyldendal",
                Title = "Harry Potter og De vises sten",
                Author = "J. K. Rowling",
                Price = 200


            };
            books.Add(harryPotter);

            //List<Newspaper> newsPapers = new List<Newspaper>();
            newsPapers.Add(politikken);
            newsPapers.Add(bt);

            Console.WriteLine();
            Console.WriteLine($"Min boghandel indeholder {newsPapers.Count} aviser:");
            foreach (var item in newsPapers)
            {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine();
            Console.WriteLine($"Boghandlen har også {books.Count} bøger:");
            foreach (var item in books)
            {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine();
            Console.WriteLine("Hvad vil du søge efter?");
            string searchResult = Search(Console.ReadLine());
            Console.WriteLine(searchResult);
        }

        public string Search(string searchText)
        {
            string searchResult = "";

            foreach(var item in newsPapers)
            {
                if (item.Title.Contains(searchText))
                {
                    searchResult += $"Avis fundet: {item.Title}, Udgivelse: {item.Date}\n";
                }
            }
            foreach(var item in books)
            {
                if (item.Title.Contains(searchText))
                {
                    searchResult += $"Bog fundet: {item.Title}, skrevet af {item.Author}\n";
                }
            }

            if (searchResult.Length > 0)
            {
                return searchResult;
            } else
            {
                return "Ingen resultater fundet";
            }
            
        }
    }
}
