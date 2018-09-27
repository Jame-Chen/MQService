using MQService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MQHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MSMQService), new Uri("net.msmq://localhost/Private/LMXQueue")))
            {
                NetMsmqBinding binding = new NetMsmqBinding(NetMsmqSecurityMode.None);
                binding.ExactlyOnce = false;
                binding.Durable = true;

                host.AddServiceEndpoint(typeof(IMSMQService).FullName, binding, "");
                host.Open();
                Console.WriteLine("服务器已经准备好");
                Console.Read();
            }
        }
    }
}
