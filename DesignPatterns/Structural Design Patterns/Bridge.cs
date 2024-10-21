using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural_Design_Patterns
{
    // Bridge is used when we need to decouple an abstraction from its implementation so that the two can vary independently.
    // The bridge uses encapsulation, aggregation, and can use inheritance to separate responsibilities into different classes.
    // The bridge pattern is a design pattern used in software engineering that is meant to "decouple an abstraction from its implementation so that the two can vary independently", introduced by the Gang of Four.
    public interface IBridgeComponent
    {
        void SendMessage(string messageType);
    }

    public abstract class SendMessage()
    {
        public IBridgeComponent _bridgeComponent;
        public abstract void Send();
    }

    public class SendSMS : SendMessage
    {
        public override void Send()
        {
            _bridgeComponent.SendMessage("SMS");
        }
    }

    public class SendEmail : SendMessage
    {
        public override void Send()
        {
            _bridgeComponent.SendMessage("SMS");
        }
    }

    public class ThirdPartyService : IBridgeComponent
    {
        public void SendMessage(string messageType)
        {
            Console.WriteLine("Sending message using third party service");
        }
    }

    public class InHouseService : IBridgeComponent
    {
        public void SendMessage(string messageType)
        {
            Console.WriteLine("Sending message using in house service");
        }
    }

    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    SendMessage sendMessage = new SendSMS();
        //    sendMessage._bridgeComponent = new ThirdPartyService();
        //    sendMessage.Send();

        //    sendMessage = new SendEmail();
        //    sendMessage._bridgeComponent = new InHouseService();
        //    sendMessage.Send();
        //}
    }
}
