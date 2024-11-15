namespace SuperheroAgency
{
    internal class MyStack<CustomStack>
    {
        private CustomStack[] items = new CustomStack[0];

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

    }
}
