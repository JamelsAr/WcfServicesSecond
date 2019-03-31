using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfModel;

namespace WcfService
{
    /// <summary>
    /// 书籍协定
    /// </summary>
    [ServiceContract]
    public interface IBookService
    {
        /// <summary>
        /// 通过Id得到书籍信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [OperationContract]
        string GetBook(string id);

        /// <summary>
        /// 得到所有书籍
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetList();

        /// <summary>
        /// 添加书籍
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        [OperationContract]
        string AddBook(Books books);


        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        string delBook(int id);

        /// <summary>
        /// 修改书籍
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        [OperationContract]
        string editBook(Books books);


        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        int calculate(int x,int y);
    }
}
