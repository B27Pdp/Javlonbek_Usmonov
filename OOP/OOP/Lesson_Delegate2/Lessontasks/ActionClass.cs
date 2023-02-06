namespace OOP.Lesson_Event.Lessontasks
{
    internal class ActionClass
    {
        public void Start()
        {
            Action<string, int> Print1 = (s, n) => Console.WriteLine(s+n);

            Print1.Invoke("Pdp B", 27);
        }
        public void Stop()
        {
            Action Print1 = () => Console.WriteLine("action");

            Print1.Invoke();
        }
        
    }
}
