namespace OOP.Lesson_Delegate.Lessontasks
{
    delegate void Delegates();
    internal class Class1
    {
        public void Start()
        {
            Delegates delegates = Stop;
            delegates += Print;
            delegates();
        }
        public void Stop()
        {
            Console.WriteLine("STOP RUN ! ! !");
        }
        public void Print()
        {
            Class2 obj = new Class2();
            Delegates delegates1=obj.Add;
            delegates1();
        }
        
    }
}
