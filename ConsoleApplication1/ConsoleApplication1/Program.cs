using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            using (var popClient = new PopClient(host, port)
            {
                Username = username,
                Password = password,
                EnableSsl = true
            })
            {
                popClient.MailPopCompleted += PopClient_MailPopCompleted;
                popClient.MailPopped += PopClient_MailPopped;
                popClient.QueryPopInfoCompleted += PopClient_QueryPopInfoCompleted;
                popClient.ChatCommandLog += PopClient_ChatCommandLog;
                popClient.ChatResponseLog += PopClient_ChatResponseLog;

                try
                {
                    popClient.PopMail();
                }
                catch (PopClientException pce)
                {
                    Console.WriteLine("PopClientException caught!");
                    Console.WriteLine(
                        "PopClientException.PopClientBusy : {0}", pce.PopClientBusy);
                }

                Console.ReadKey();
            }
        }
    }
}
