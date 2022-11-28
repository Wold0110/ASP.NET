namespace _2022_09_20
{
    public class Person
    {
        public string name;
        public int age;
        public Person(string name,int age)
        {
            this.name = name;this.age = age;
        }
        public static List<Person> TestPeople()
        {
            return new List<Person>()
            {
                new("Salyam",26),
                new("Illes", 45),
                new("III. Karoly",75)
            };
        }
    }
}
