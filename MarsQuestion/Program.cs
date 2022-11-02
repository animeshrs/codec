using System;
using Services;


namespace MarsQuestion
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetMarsHoverCoordinatesAndDirection();
        }

        public static void GetMarsHoverCoordinatesAndDirection()
        {
            var xPosition = 1;
            var yPosition = 1;
            Console.WriteLine("Enter x value: ");
            var xMaxStr = Console.ReadLine();
            Console.WriteLine("Enter y value: ");
            var yMaxStr = Console.ReadLine();

            var xMax = int.Parse(xMaxStr);
            var yMax = int.Parse(yMaxStr);

            Console.WriteLine("Enter command: ");
            var initialCommand = Console.ReadLine(); // "FFRFLFLF";
            var commandsArray = initialCommand.ToCharArray();

            var newDirection = "North";
            foreach (var commandStr in commandsArray)
            {
                var command = commandStr.ToString();
                newDirection = MarsService.UpdatedDirection(command, newDirection);
                var res = MarsService.GetUpdatedCoodinates(command, newDirection, xPosition, yPosition, xMax, yMax);
                xPosition = res.xPosition;
                yPosition = res.yPosition;
            }

            Console.WriteLine(newDirection);
            var result = new Tuple<int, int>(xPosition, yPosition);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
