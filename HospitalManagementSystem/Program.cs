
namespace HospitalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Xestenin tam adini daxil edin:");
                string patientFullName = Console.ReadLine();
                Dictionary<string, int> kanTahlili = BloodTestModule.GetBloodTest();

                BloodTestModule.DoBloodTest(kanTahlili,patientFullName);

            }
        }
    }
}
