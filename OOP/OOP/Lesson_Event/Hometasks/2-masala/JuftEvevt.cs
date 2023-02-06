/*OnEvenNumberFound nomli event hosil qiling 
 * va bu event'ni to'plam ichida juft sonlar topilgan paytda ishlashligini ta'minlang*/
namespace OOP.Lesson_Event.Hometasks._2_masala
{
    delegate void Delegate_Juft(int n);
    internal class JuftEvevt
    {
        public event Delegate_Juft? Event_Juft;
        public void Juft_N(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Event_Juft.Invoke(list[i]);
                }
            }
        }
    }
}
