internal class Program
{
    static void Main(string[] args)
    {
        Cat cat1 = new Cat(1);
        cat1.Method1();
        cat1.Method2();
        cat1.Method3();
        Animal cat2 = new Cat(2);
        cat2.Method1();
        cat2.Method2();
        cat2.Method3();
        Dog dog1 = new Dog(1);
        dog1.Method1();
        dog1.Method2();
        dog1.Method3();
        Animal dog2 = new Dog(2);
        dog2.Method1();
        dog2.Method2();
        dog2.Method3();

    }
    public abstract class Animal
    {
        private int _number;
        public abstract string Word
        {
            get;
        }
        public Animal(int number)
        {
            _number = number;
        }
        public void Method1()
        {
            Console.WriteLine($"Animal{_number}: Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine($"Animal{_number}: Method2");
        }

        public abstract void Method3();
    }
    public class Cat: Animal
    {
        private int _number;
        public Cat(int number) : base(number) 
        {
            _number = number;
        }
        public override string Word
        {
            get
            {
                return "Word";
            }
        }

        public new void Method1()
        {
            Console.WriteLine($"Cat{_number}: new Method1");
        }
        public override void Method2()
        {
            Console.WriteLine($"Cat{_number}: override Method2");
        }
        public override void Method3()
        {
            Console.WriteLine($"Cat{_number}: Method3");
        }
    }
    public class Dog: Animal
    {
        public override string Word => "Word";

        private int _number;
        public Dog(int number) : base(number)
        {
            _number= number;
        }
        public override void Method3()
        {
            Console.WriteLine($"Dog{_number}: Method3");
        }
    }

}
