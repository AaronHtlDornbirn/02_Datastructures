using Stack;

class Programm
{
    public static void Main(string[] args)
    {
        CustomStack<int> stack = new CustomStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        
        Console.WriteLine(stack.size());
        
        stack.Pop();
        
        Console.WriteLine(stack.size());
    }
}