namespace ChainOfResponsibility
{
    public class CalculateObject
    {
        public CalculateObject(int firstNumber, int secondNumber, CalculationType calcType)
        {
            FirstNumber = firstNumber;
            SecondNumbe = secondNumber;
            CalcType = calcType;
        }

        public int FirstNumber { get; set; }

        public int SecondNumbe { get; set; }

        public CalculationType CalcType { get; set; }
    }
}
