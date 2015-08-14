using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;

namespace CodeFirstIdeasDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var IdeaDB = new IdeasContext())
            {   

                var queryIdea = from i in IdeaDB.ideas
                                orderby i.id
                                select i;
                Console.WriteLine("All idea in the database: ");
                foreach (var item in queryIdea)
                {
                    Console.WriteLine("Id: {0}, Title: {1}, Status: {2}", 
                        item.id, item.title, item.status);
                }                                 
            }
            Console.ReadKey();
        }
    }
}
