using System.Collections;
using System.Xml.Linq;

namespace SuperheroAgency
{
    internal class MyStack<CustomStack> : System.Collections.ICollection
    {
        private CustomStack[] items = new CustomStack[0];

    
        public bool IsSynchronized => throw new NotImplementedException();
        public object SyncRoot => throw new NotImplementedException();

        public int Count   // property
        {
            get { return items.Length; }   // get method
        }



        public void Push(CustomStack item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }

        public CustomStack Pop()
        {
            CustomStack item = items[items.Length - 1];
            Array.Resize(ref items, items.Length - 1);
            return item;
        }





        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }



}
