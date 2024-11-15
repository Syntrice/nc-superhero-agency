// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> list = new List<string>()
{
    "hello",
    "world", 
};

Dictionary<int, string> dictionary = new Dictionary<int, string>()
{
    { 1, "a" },
    { 2, "b" },
};

static T GetLastItem<T>(T[] list)
{
    return list[list.Length - 1];
}

int[] intArray = { 1, 5, 2, 8, 6 };
Console.WriteLine(GetLastItem(intArray));