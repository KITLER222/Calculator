namespace arrayInputAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("выбирите оперецию (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;
            switch (operation) // похожее действие на if/else
            {
                case "+": 
                    result = num1 + num2;
                    break; //прирвыайет дальнейшие выполнение кода

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 != 0) //проверка на 0
                    {
                        result = num2 / num1;
                    }
                    else
                    {
                        Console.WriteLine("ошибка деленеи на 0 запрещено");
                    }
                    break;

                default: // то что выполнится по умолчанию если ни один из вариантов не подошел
                    Console.WriteLine("неизвестная операция");
                    break;
            }
            Console.WriteLine($"результат: {result}");
        }

    }
}