using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfService;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //没有通过配置文件的方式启动程序

            //提供服务的主机
            using (ServiceHost host = new ServiceHost(typeof(BookService)))
            {
                host.AddDefaultEndpoints();
                //添加终结点
                host.AddServiceEndpoint(typeof(IBookService), new WSHttpBinding(), "http://127.0.0.1:9658/BookService");
                //判断控制服务元数据和相关信息的发布
                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    //创建一个控制服务
                    ServiceMetadataBehavior metdata = new ServiceMetadataBehavior();
                    //控制服务元数据和相关信息的发布时使用Http/Get进行检索
                    metdata.HttpGetEnabled = true;
                    //http/Get请求的位置  
                    metdata.HttpGetUrl = new Uri("http://127.0.0.1:9658/BookService/wcf");
                    //添加到主机中
                    host.Description.Behaviors.Add(metdata);
                }
                //添加一个事件
                host.Opened += delegate
                {
                    Console.WriteLine("BookService已启动，按任意键终止服务！");
                };

                //启动服务
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
