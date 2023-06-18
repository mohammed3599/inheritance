namespace keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A anyName = new A(5);
            anyName.getDoubleNumberOfWheels(); // 10
            Console.WriteLine(A.someNumber);

            A anyValue = new A(6);
            anyValue.getDoubleNumberOfWheels(); // 12
            Console.WriteLine(A.someNumber);

            anyName.getDoubleNumberOfWheels(); // 12
            Console.WriteLine(anyName.getDoubleNumberOfWheels());
            Console.WriteLine(A.someNumber);
        }
    }
}