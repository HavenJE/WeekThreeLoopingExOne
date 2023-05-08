

// Week3 - Write an application named SumFiveInts that allows the user to enter five integers and displays their sum.
// Using for loop
//class SumFiveInts
//{
//    static void Main()
//    {
//        int count;
//        int num;
//        int sum = 0;
//        const int MAX = 5;

//        for (count = 0; count < MAX; count++)
//        {
//            Console.WriteLine("Please enter your five integers below: ");
//            num = Convert.ToInt32(Console.ReadLine());
//            sum += num;
//            // Console.WriteLine("The sum of the five integers is: {0}", sum);
//        }

     
//        Console.WriteLine("The sum of the five integers is: {0}", sum);
//    }
//}


// Using While loop

class SumFiveInts
{
    static void Main()
    {
        int count = 0;
        int num;
        int sum = 0;
        const int MAX = 5;

        while (count < MAX)
        {
            Console.WriteLine("Please enter your five integers below: ");
            num = Convert.ToInt32(Console.ReadLine());
            count++;
            sum += num;
            // Console.WriteLine("The sum of the five integers is: {0}", sum);
        }
        Console.WriteLine("\nThe sum is: {0}", sum);
    }
}