namespace Lab_1_2
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public int Course { get; set; }
        public double Rating { get; set; }

        public Student(string name, int age, int course, double rating)
        {
            Name = name;
            Age = age;
            Course = course;
            Rating = rating;
        }

        public void EditStudent(string name, int age, double rating)
        {
            Name = name;
            Age = age;
            Rating = rating;
        }

        public string GetRole(int course)
        {
            if (course <= 4)
                Role = "бакалавр";
            else
                Role = "магістр";
            return Role;
        }

        public void Student_Rating()
        {
            if (Rating >= 82)
                Console.WriteLine("Привіт відмінникам");
            else if (Rating <= 60)
                Console.WriteLine("Перездача!");
            else
                Console.WriteLine("Можна вчитися ще краще!");
        }

        static void Main(string[] args)
        {


            Student stud = new Student("Вася", 19, 2, 60);
            string stRole = stud.GetRole(2);
            Console.WriteLine("Цей студент  " + stRole);
            stud.Student_Rating();
            stud.EditStudent("Петро", 20, 90);

            Console.WriteLine("Оновлені дані про студента");
            Console.WriteLine("Ім’я " + stud.Name);
            Console.WriteLine("Вік " + stud.Age);
            Console.WriteLine("Курс " + stud.Course);
            Console.WriteLine("Рейтинг " + stud.Rating);
        }
    }
}
