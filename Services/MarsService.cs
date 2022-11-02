namespace Services
{
    public static class MarsService
    {
        static void Main(string[] args)
        {
            
        }

        public static string UpdatedDirection(string command, string direction)
        {
            if (command.Equals("F")) return direction;
            var concatenatedValue = command + "-" + direction;
            switch (concatenatedValue)
            {
                case "L-North":
                    return "West";
                case "L-West":
                    return "South";
                case "L-South":
                    return "East";
                case "L-East":
                    return "North";
                case "R-North":
                    return "East";
                case "R-West":
                    return "North";
                case "R-South":
                    return "West";
                case "R-East":
                    return "South";
                default: return direction;
            }
        }

        public static (int xPosition, int yPosition) GetUpdatedCoodinates(string command, string direction, int x, int y, int xMax, int yMax)
        {
            if (!command.Equals("F")) return (x, y);

            switch (direction)
            {
                case "North":
                    return yMax <= y ? (x, yMax) : (x, y + 1);
                case "East":
                    return xMax <= x ? (xMax, y) : (x + 1, y);
                case "South":
                    return y <= 1 ? (x, 1) : (x, y - 1);
                case "West":
                    return (x <= 1) ? (1, y) : (x - 1, y);

            }
            return (x, y);
        }

    }
}
