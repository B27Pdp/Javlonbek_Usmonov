namespace OOP.Lesson_Delegate2.Hometasks
{
    internal class Action1
    {
        public Action<string, string> action1 = (s1, s2) =>
        {
            /*s1 = "usmonov";
            s2 = "javlon";*/
            if (s1[0] == 'u' && s2[0] == 'j')
            {
                Console.WriteLine(s1 + " " + s2);
            }
            else Console.WriteLine("else");
        };
        public void Stop()
        {
            action1.Invoke("usmonov","javlon");
        }
      
        
    }
}
