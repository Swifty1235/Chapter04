namespace MyRootLib
{
    public class Root
    {
        /// <summary>
        /// this method calculates the square of the number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double MyRoot(double number)
        {
            double root;
            // Correctly using Math.Pow to calculate the square of the number
            root = Math.Pow(number, 2); // This will calculate number^2, not the square root
            Console.WriteLine("The square of " + number + " is " + root);
            return root;
        }
    }
}
