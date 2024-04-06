using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class BloodTestModule
    {
        public static Dictionary<string, int> GetBloodTest()
        {
            Random random = new Random();
            Dictionary<string, int> bloodTest = new Dictionary<string, int>();
            bloodTest.Add("Leykosit", random.Next(1, 101));
            bloodTest.Add("Eritrosit", random.Next(1, 101));
            bloodTest.Add("Kreatinin", random.Next(1, 101));
            return bloodTest;
        }
        public static void DoBloodTest(Dictionary<string, int> bloodTest, string patientName)
        {
            Console.WriteLine("Qan tehlili neticeleri:");
            foreach (var item in bloodTest)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in bloodTest)
            {
                if (item.Value >= 70)
                {
                    string Report = $"Xeste - {patientName}-da {item.Key} uzre tehlil neticesi normadan artiqdir !!! Deger - {item.Value} ";
                    SendAlert(Report);
                }
            }
        }

        private static void SendAlert(String message)
        {
            ViaEmail(message);

            ViaSMS(message);

            ViaTelegram(message);
        }

        private static void ViaEmail(string Report)
        {
            Console.WriteLine($"E-mail gönderildi - {Report}");
        }

        private static void ViaSMS(string Report)
        {
            Console.WriteLine($"SMS gönderildi -  {Report}");
        }
        private static void ViaTelegram(string Report)
        {
            Console.WriteLine($"Telegram gönderildi - {Report}");
        }
    }
}
