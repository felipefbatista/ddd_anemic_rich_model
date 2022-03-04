using System;

namespace AnemicModel.Infrastructure
{
    public static class EmailService
    {
        public static void SendMail(string to, string body) { Console.WriteLine("Email sent"); }
    }
}