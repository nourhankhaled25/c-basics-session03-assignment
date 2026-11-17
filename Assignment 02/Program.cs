using System.Text;
using System.Threading.Channels;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            string title = "clean code";
            string newTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(newTitle);
            #endregion

            #region Q02

            string vaR1 = "clean code";
            string vaR2 = "clean code";
            bool flag = ReferenceEquals(vaR1, vaR2);
            Console.WriteLine(flag);

            #endregion

            #region Q03

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb);

            #endregion

            #region Q04

            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);

            #endregion

            #region Q05

            int pages = 464;
            Console.WriteLine("Book: " + title + ", Pages: " + pages);

            #endregion

            #region Q06

            Console.WriteLine($"Book: {title}, Pages: {pages}");

            #endregion

            #region Q07

            string res = string.Format("Book: {0}, Pages: {1}", title, pages);
            Console.WriteLine(res);

            #endregion

            #region Q08

            if (pages > 300)
                Console.WriteLine("Long Book");

            else Console.WriteLine("Short Book");

            #endregion

            #region Q09 

            bool isAvailable = true;
            if (pages > 300 && isAvailable)
                Console.WriteLine("You can borrow this book");

            #endregion

            #region Q10

            string title2 = "Refactoring";
            switch (title2)
            {
               case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

               case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

               default : Console.WriteLine("Never heard of it");
                    break;
            }

            #endregion

            #region Q11

            string ress = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(ress);

            #endregion

            #region Q12

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i+1}. {books[i]}");
            }
            #endregion

            #region Q13

            int size = books.Length - 1 ;
            while (size >= 0) 
            {
                Console.WriteLine(books[size]);
                size--;
            }
            #endregion

            #region Q14

            int count = 3;
            do
            {
                Console.WriteLine("Checking book...");
                count--;
            } while (count > 0);

            #endregion

            #region Q15

            foreach (string j in books) 
            {
                Console.WriteLine(j);
            }

            #endregion

            #region Q16

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "Refactoring")
                    break;
                Console.WriteLine($"{i + 1}. {books[i]}");

            }
            #endregion

            #region Q17

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine($"{i + 1}. {books[i]}");

            }
            #endregion

            #region Q18

            void PrintFirstBook(string[] metBook)
            {

                if (!books.Any())
                    return;
                Console.WriteLine(metBook[0]);

            }
            PrintFirstBook(books);

            #endregion

        }
    }
}
