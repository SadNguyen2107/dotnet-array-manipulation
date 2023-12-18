namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] numbers = new Int32[5];

            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine(total.ToString());
        }
    }
}