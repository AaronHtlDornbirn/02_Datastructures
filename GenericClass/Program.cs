using GenericClass;

class Programm
{
    static void Main(string[] args)
    {
        GenericList<int> numberone = new GenericList<int>();
        numberone.Add(1);
        Console.WriteLine(numberone.GetList(0));

        GenericList<string> numbertwo = new GenericList<string>();
        numbertwo.Add("Hello");
        Console.WriteLine(numbertwo.GetList(0));

        GenericList<string> numberthree = new GenericList<string>();
        numberthree.Add("Aaron");
        Console.WriteLine(numberthree.GetList(0));
    }
}