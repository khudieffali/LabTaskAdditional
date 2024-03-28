using LabTaskAddititonal;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)

    {

        #region Task Lab 1

        Employee employee = new("Ali", 500, false);
        Assistant assistant = new();
        Console.WriteLine(assistant.GetFeedBack(employee));
        #endregion

        #region Task Lab 2
        Student st1 = new("Selver", "Ceferov", 22, true);
        Student st2 = new("Eli", "Semmedov", 28, false);
        Student st3 = new("Pasha", "Allahverdiyev", 24, true);
        Student st4 = new("Hikmet", "Xidirzade", 25, false);
        Student st5 = new("Murad", "Aliyev", 21, true);
        Student st6 = new("Pasha", "Ahmadov", 23, false);
        Student[] stArr = { st1, st2, st3 };
        Student[] stArr2 = { st4, st5, st6 };

        Group gr = new("C#Backend", stArr);
        Group gr2 = new("Frontend", stArr2);

        //getall method
        gr.GetAll();

        // getonlinestudents method
        gr2.GetOnlineStudents();

        //getofflinestudents method
        gr.GetOfflineStudents();

        #endregion





    }
}
