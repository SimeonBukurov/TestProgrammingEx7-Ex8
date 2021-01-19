using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha8
{


    public delegate string MessageHandler(object sender, EventArgs e);
    class Announcer
    {
        public event MessageHandler MessageChanged;
        public event MessageHandler MessageChangeEvent;
        private string currentMessage;
        public string CurrentMessage
        {
            get { return currentMessage; }
            set { currentMessage = value; }
        }
        public void ChangeMessage(string NewMessage)
        {
            try
            {
                currentMessage = NewMessage;
                OnMessageChanged();
            }
            catch (ArgumentNullException arg)
            { Console.WriteLine("The new message cannot be null or empty.", arg.Message); }
        }
        public void OnMessageChanged()
        {
            (MessageChanged as MessageHandler)?.DynamicInvoke(currentMessage);
        }
    }
    public class Listener
    {
        public string MessageChanged(string NewMessage)
        {
            return "Message has been changed to " + NewMessage;
        }
        
    }
class Program
        {
            static void Main(string[] args)
            {
            }
        }
}
