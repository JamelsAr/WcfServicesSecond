using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfCommon;
using WcfModel;

namespace WcfService
{
    /// <summary>
    /// 书籍服务协定实现
    /// </summary>
    public class BookService : IBookService
    {
        BookShopPlusEntities book = new BookShopPlusEntities();

        /// <summary>
        /// 通过Id得到书籍信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string GetBook(string id)
        {
            int bookId = Convert.ToInt32(id);
            try
            {
                //var books = (from s in book.Books
                //         where s.Id == id
                //         select s).SingleOrDefault();
                var books = book.Books.Where(e => e.Id.Equals(bookId)).SingleOrDefault();

                return XmlHelper.ToXML<Books>(books);
            }
            catch (Exception ex)
            {
                //这里如果出现异常，则返回一个自定义的错误信息，用于进行调试，可以看到更详细的异常信息，方便定位问题。
                string reason = GetErrorMessage(ex);
                SQLError error = new SQLError("更新数据库操作", reason);
                throw new FaultException<SQLError>(error, new FaultReason(reason), new FaultCode("Edit"));
            }
        }

        /// <summary>
        /// 得到所有书籍
        /// </summary>
        /// <returns></returns>
        public string GetList()
        {
            try
            {
                List<Books> books = (from b in book.Books select b).Take(10).ToList<Books>();
                return XmlHelper.ToXML<List<Books>>(books);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 添加书籍
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        public string AddBook(Books books)
        {
            try
            {
                book.Books.Add(books);
                //保存到数据库
                book.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "true";
        }

        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string delBook(int id)
        {
            try
            {
                var books = book.Books.Where(e => e.Id == id).SingleOrDefault();
                book.Books.Remove(books);
                book.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "true";
        }

        /// <summary>
        /// 修改书籍
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        public string editBook(Books books)
        {
            try
            {
                //得到一条数据
                var bk = book.Books.Where(e => e.Id == books.Id).SingleOrDefault();
                //进行修改
                bk.Title = books.Title;
                bk.Author = books.Author;
                bk.PublishDate = books.PublishDate;
                bk.UnitPrice = books.UnitPrice;
                bk.TOC = books.TOC;
                //提交
                book.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "true";
        }


        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int calculate(int x, int y)
        {
            return x + y;
        }

        StringBuilder sb = new StringBuilder();
        /// <summary>
        /// 递归获取错误信息的内部错误信息，直到InnerException为null
        /// </summary>
        /// <param name="ex"></param>
        private string GetErrorMessage(Exception ex)
        {
            if (ex.InnerException != null)
            {
                sb.Append("InnerException：" + ex.Message + ",");
                GetErrorMessage(ex.InnerException);
            }
            else
            {
                sb.Append(ex.Message + ",");
            }
            return sb.ToString();
        }
    }
}
