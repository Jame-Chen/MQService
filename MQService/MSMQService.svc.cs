using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MQModel;

namespace MQService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“MSMQService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 MSMQService.svc 或 MSMQService.svc.cs，然后开始调试。
    public class MSMQService : IMSMQService
    {
        public void PlaceOrder(OrderEntry entry)
        {
            Console.WriteLine("收到订单: {0}", entry);
        }
    }
}
