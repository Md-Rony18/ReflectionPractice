namespace ReflectionPractice
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Md Rony Mondol";
            person.Id = 101;
            person.dep = "Computer";
            person.student = new Student
            {
                Name = "Md Jony Mondol",
            };
            person.child = new Childred
            {
                Age = 25,
                Name="Esha"
            };

            //person.child = new Childred[2]
            //{
            //    new Childred
            //    {
            //        Name ="Esrat Jahan Esha",
            //        age =20 
            //    },
            //    new Childred
            //    {
            //        Name="Sadia Akter Joti",
            //        age=13,
            //    },
            //};
            string[] names = new string[2]
            {
               "Rony",
               "Esha",
            };
            string jason = JasonFomatter.Convert(person);
            Console.WriteLine(jason);
            //int count = 5;
            //int factorial=JasonFomatter.Counter(count);
            //Console.WriteLine(factorial);
            Console.WriteLine("---------------------");
            //string name = JasonFomatter.Stringloop<Person>(person);
            //Console.WriteLine(name);
            //int nam=JasonFomatter.Arrayconveter(7);
            //Console.WriteLine(nam);
        }
    }
}

