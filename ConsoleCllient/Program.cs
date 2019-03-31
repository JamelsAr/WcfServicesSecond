using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfCommon;
using WcfModel;

namespace ConsoleCllient
{
    class Program
    {
        static void Main(string[] args)
        {
            BookServiceRef.BookServiceClient bookService = new BookServiceRef.BookServiceClient();
            //string info = bookService.GetList();
            Books book = XmlHelper.DeSerializer<Books>(bookService.GetBook("5168"));



            Console.WriteLine("标题："+book.Title);

            //Console.WriteLine("计算结果：" + bookService.calculate(2, 2));

            Console.ReadLine();
        }
    }
}
