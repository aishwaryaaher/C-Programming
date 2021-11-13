using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // i can make  some change  to make code small

            Book book1 = new Book("Harry Potter","JK Rowling",5000);
            Book book2 = new Book("Lord Of The Rings", "Tolkein", 3000);
            Book book3= new Book();
            // i can also update the value of books
             book2.title="The Habbits";
            Console.WriteLine(book2.title);
            Console.ReadLine();








            //Book book1 = new Book();
            ///*
            //// using  parameters  
            //Book book1 = new Book("Mike");
            //*/

            //book1.title = "Harry Potter";
            //book1.author ="Jk Rowling";
            //book1.pageNo = 4000;

            //Book book2 = new Book(); 
           
            ///* // using  parameters
            //     Book book2 = new Book("John");
            //*/
            
            //book2.title = "Lord Of The Rings";
            //book2.author = "Tolkein";
            //book2.pageNo = 4000;

            //Console.WriteLine(book1.title);
            //Console.WriteLine(book1.author);
            //Console.WriteLine(book1.pageNo);

            //Console.WriteLine("");

            //Console.WriteLine(book2.title);
            //Console.WriteLine(book2.author);
            //Console.WriteLine(book2.pageNo);

          
        }
    }
}
