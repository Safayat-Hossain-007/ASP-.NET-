class FunctionPractice
{
    public static void Main(String[] args)
    {
        int value = doubleValue(2);
        Console.WriteLine(value);
        int []x = arrayInput(5);
        foreach (var arr in x)
        {
            Console.WriteLine(arr);
        }
        Console.ReadLine();
    }

    static int[] arrayInput(int x)
    {
        int elements = x;
        int[] arrayInput = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            Console.Write("Enter the numbers: ");
            arrayInput[i] = Convert.ToInt32(Console.ReadLine());
        }

        return arrayInput;
    }
    public static int doubleValue(int value)
    {
        return value * 2;
    }
}