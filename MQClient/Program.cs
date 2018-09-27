using MQModel;
using MQService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MQClient
{
    class Program
    {
        static void Main(string[] args)
        {
            NetMsmqBinding binding = new NetMsmqBinding(NetMsmqSecurityMode.None);
            binding.ExactlyOnce = false;
            binding.Durable = true;
            ChannelFactory<IMSMQService> channel =
             new ChannelFactory<IMSMQService>(
                //这里面解释一下：localhost代表是本机服务器，Private字面上是私有，这里面表示是“消息队列”里面的“专用队列”，“LMXQueue”是我们专用队列的一个类似“消息组”的一个名称。
                    binding, new EndpointAddress("net.msmq://localhost/Private/LMXQueue"));
            IMSMQService client = channel.CreateChannel();
            for (int i = 0; i < 100000; i++)
            {
                client.PlaceOrder(
              new OrderEntry()
              {
                  OrderID = 1,
                  OrderDate = DateTime.Now,
                  UnitPrice = 10,
                  Quantity = 10
              });
            }


            Console.WriteLine("发送了一个订单");
            Console.Read();
        }
    }
}
