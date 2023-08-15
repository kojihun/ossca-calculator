namespace OSCCA
{
    class Calculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("┌───────────────────────┬───────┐");
            Console.WriteLine("│   OSSCA  CALCULATOR   │   +   │");
            Console.WriteLine("├───────┬───────┬───────┼───────┤");
            Console.WriteLine("│   1   │   2   │   3   │   -   │");
            Console.WriteLine("├───────┼───────┼───────┼───────┤");
            Console.WriteLine("│   4   │   5   │   6   │   *   │");
            Console.WriteLine("├───────┼───────┼───────┼───────┤");
            Console.WriteLine("│   7   │   8   │   9   │   /   │");
            Console.WriteLine("└───────┴───────┴───────┴───────┘");

            while (true)
            {
                Console.Write("계산식을 입력하세요. (ex: 1 + 2): ");
                string input = Console.ReadLine();
                string[] elements = input.Split(' ');
                if (elements.Length != 3)
                {
                    Console.WriteLine("잘못된 입력 방식입니다. 예시와 같이 입력해주세요.");
                    continue;
                }

                double number1 = Convert.ToDouble(elements[0]);
                double number2 = Convert.ToDouble(elements[2]);
                char operation = Convert.ToChar(elements[1]);

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = number1 + number2;
                        break;
                    case '-':
                        result = number1 - number2;
                        break;
                    case '*':
                        result = number1 * number2;
                        break;
                    case '/':
                        result = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("지원하지 않는 연산자입니다.");
                        continue;
                }

                string formattedResult;
                if (result % 1 == 0)
                {
                    formattedResult = result.ToString("0");
                }
                else
                {
                    formattedResult = result.ToString("0.0");
                }
                
                string resultText = input + " = " + formattedResult;
                string formattedText = resultText.PadLeft((23 + resultText.Length) / 2).PadRight(23);
                
                Console.WriteLine("=============RESULT==============");
                Console.WriteLine("┌───────────────────────┬───────┐");
                Console.WriteLine("│" +  formattedText  + "│   +   │");
                Console.WriteLine("├───────┬───────┬───────┼───────┤");
                Console.WriteLine("│   1   │   2   │   3   │   -   │");
                Console.WriteLine("├───────┼───────┼───────┼───────┤");
                Console.WriteLine("│   4   │   5   │   6   │   *   │");
                Console.WriteLine("├───────┼───────┼───────┼───────┤");
                Console.WriteLine("│   7   │   8   │   9   │   /   │");
                Console.WriteLine("└───────┴───────┴───────┴───────┘");
                Console.WriteLine("=================================");

                break;
            }
        }
    }
}