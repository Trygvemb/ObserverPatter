namespace Øvelse4
{
    class Program
    {
        static void Main(string[] args)
        {
            Academy p = new Academy("UCL", "Seebladsgade");


            Student s1 = new Student(p, "Jens");
            Student s2 = new Student(p, "Niels");
            Student s3 = new Student(p, "Susan");

            p.Students += s1.Update;
            p.Students += s2.Update;
            p.Students += s3.Update;


            p.Message = "Så er der julefrokost!";

            p.Students -= s2.Update;

            p.Message = "Så er der fredagsbar!";

            Console.ReadKey();
        }


    }
}

