using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface.Adapter_Pattern
{
    internal class AdapterDemo
    {
    }

    public interface Communication
    {
        void SendMessage(String message);
    }

    class Email : Communication
    {
        String recipient;

        public Email(String recipient)
        {
            this.recipient = recipient;
        }

        public void SendMessage(String Message)
        {
            Console.WriteLine($"Email sent to {recipient}");
        }
    }
    class SMS : Communication
    {
        String recipient;

        public SMS(String recipient)
        {
            this.recipient = recipient;
        }

        public void SendMessage(String Message)
        {
            Console.WriteLine($"SMS sent to {recipient}");
        }
    }

    public class WhatsApp
    {
        String receiver;

        public WhatsApp(String receiver)
        {
            this.receiver = receiver;
        }

        public void SubmitMessage(String message)
        {
            Console.WriteLine( message + " Message sent to on your whats app number.");
        }
    }

    public class WhatsAppAdapter : Communication
    {
        private WhatsApp _whatsApp;

        public WhatsAppAdapter(WhatsApp whatsApp)
        {
            _whatsApp = whatsApp;
        }
        public void SendMessage(string message)
        {
            _whatsApp.SubmitMessage(message);
        }
    }

    class Subscriber
    {

        String firstName;
        String lastName;
        List<Communication> notifier = new List<Communication>();

        public Subscriber(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void AddNotifier(Communication comm)
        {
            notifier.Add(comm);
        }

        public void NotifySubscriber(String message)
        {
            foreach (var comm in notifier)
                comm.SendMessage(firstName);
        }
    }
}
