using System.Collections;

namespace OOP.Lesson_IEnuriable.Lessontasks
{
    public class Generic_IEnumerator<T> : IEnumerable<T>
    {
        List<T> list=new List<T>();
        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        public void AddValue(T item) => list.Add(item);
        public void RemoveValue(T item) => list.Remove(item);

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Generic_IEnumerator(List<T> list
            )
        {
            this.list = list;
        }
    }
}
