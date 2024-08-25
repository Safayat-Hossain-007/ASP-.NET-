class Exercise
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the width : ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        
        Console.WriteLine("The area of the circle is " + calculateArea(width, height));
        Console.ReadLine();

    }

    static double calculateArea(double width,double height)
    {
        double result = 0.5* width * height;
        return result;
    }
}