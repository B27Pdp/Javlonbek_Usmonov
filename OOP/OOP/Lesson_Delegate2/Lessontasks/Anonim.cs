namespace OOP.Lesson_Event.Lessontasks
{
    //delegate int Mydelegate(int n);
    internal class Anonim_Obj
    {
        public delegate int AnonimDelegate(int num);
        public void ToStart()
        {
            /*AnonimDelegate mydelegate = delegate (int num)
            {
                return num * num;            
            };
            Console.WriteLine(mydelegate(5));*/
            AnonimDelegate mydelegate = (num) => num*num;
            Console.WriteLine(mydelegate(8));
        }



        /*public void Pow(int n)
        {
            Console.WriteLine(n*n);
        }*/
    }
}
