namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Father father = new Son();
            father.Surname();
            father.Eyecolor();

            Son son = new Son();
            son.Name("Tom");
        }
    }
}