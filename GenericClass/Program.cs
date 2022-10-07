using GenericClass;

class Programm
{
    static void Main(string[] args)
    {
        GenericList<int> list1 = new GenericList<int>();
        list1.Add(1);

        Console.WriteLine(list1.GetList(0));

        GenericList<string> list2 = new GenericList<string>();
        list2.Add("hellou");
        Console.WriteLine(list2.GetList(0));
    }
}