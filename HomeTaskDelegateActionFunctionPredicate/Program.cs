using HomeTaskDelegateActionFunctionPredicate.Models;
using System.Threading.Tasks;

namespace HomeTaskDelegateActionFunctionPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Person shahin =new Person("Shahin","Alizada",20);
            //Person mehemmed = new Person("Mehemmed","Orucov",21);
            //Person meydan = new Person("Meydan","ISgenderli",22);

            //List<Person> people = new List<Person>();
            //people.Add(shahin);
            //people.Add(mehemmed);
            //people.Add(meydan);


            //people.FindAll(s => s.Name=="Shahin").ForEach(s => Console.WriteLine(s.Name+" "+s.Surname+" "+s.Age));//Adi Shahin olan telebeni gosterin

            //people.FindAll(s => s.Surname.ToLower().Contains("ov")||
            //                 s.Surname.ToLower().Contains("ova")).ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age)); //Soyadinda ov ve ya olub olmadigini yoxluyur

            //people.FindAll(s=>s.Age>20).ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age)); //Yasi 20 den cox olanlar gorunsun
            #endregion
            #region 
            Exam riyaziyyat = new Exam("Riyaziyyat",120,DateTime.Now);
            Exam ingilis = new Exam("Ingilis dili",90,DateTime.Today);
            Exam tarix = new Exam("Tarix",90,DateTime.Now);

            Console.WriteLine(riyaziyyat.StartDate);

            List<Exam> exams = new List<Exam>();
            exams.Add(ingilis);
            exams.Add(tarix);
            exams.Add(riyaziyyat);

            riyaziyyat.Start() ;
            exams.FindAll(s => s.ExamDuration > 120).ForEach(s => Console.WriteLine(s.Subject));//2 saatdan cox olan ımtahanlar
            exams.FindAll(s => s.StartDate <=   s.StartDate.AddDays(7)).ForEach(s => Console.WriteLine(s.Subject));//Son 1 hefte olan imtahanlar
            exams.FindAll(s => s.StartDate <=  s.StartDate.AddDays(7)).ForEach(s => Console.WriteLine(s.Subject)); // Davam eden imtahan
            #endregion


        }

    }
}
