using System.Collections;

namespace OOP.Lesson_IEnumerator.Hometasks._1_masala
{
    public class Name_Class<T> : IEnumerable<T>
    {
        private List<T> list = new List<T>();
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
        public void AddValue(T item)
        {
            list.Add(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }
        public void Remove(T item)
        {
            list.Remove(item);
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Name_Class(params T[] arr )
        {
            this.list = arr.ToList<T>();
        }
    }
}
