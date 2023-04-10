float rubles = 1000f;
float dollars = 1000f;
float euroCount = 1000f;

float rubToUsd = 0.014f;
float rubToEur = 0.011f;
float usdToEur = 0.85f;
float usdToRub = 73.89f;
float eurToUsd = 1.18f;
float eurToRub = 87.64f;

Console.WriteLine("Конвертор валют");

while (true)
{
    Console.WriteLine($"Ваш баланс:\nРубли = {rubles}\nДоллары = {dollars}\nЕвро = {euroCount}");

    Console.WriteLine("Выбурите валюту, которую хотите конвертировать");
    Console.WriteLine("1.Рубли\n2.Доллары\n3.Евро");

    int fromCurrency = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Выбурите валюту, в которую хотите конвертировать");
    Console.WriteLine("1.Рубли\n2.Доллары\n3.Евро");

    int toCurrency = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите сумму, которую вы хотите конвертировать");

    float valueToConvert = float.Parse(Console.ReadLine());

    switch (fromCurrency)
    {
        case 1:
            switch (toCurrency)
            {
                case 2:
                    rubles -= valueToConvert;
                    dollars += valueToConvert * rubToUsd;
                    break;
                case 3:
                    rubles -= valueToConvert;
                    euroCount += valueToConvert * rubToEur;
                    break;
            }
            break;
        case 2:
            switch (toCurrency)
            {
                case 1:
                    dollars -= valueToConvert;
                    rubles += valueToConvert * usdToRub;
                    break;
                case 3:
                    dollars -= valueToConvert;
                    euroCount += valueToConvert * usdToEur;
                    break;
            }
            break;
        case 3:
            switch (toCurrency)
            {
                case 1:
                    euroCount -= valueToConvert;
                    rubles += valueToConvert * eurToRub;
                    break;
                case 2:
                    euroCount -= valueToConvert;
                    dollars += valueToConvert * eurToUsd;
                    break;
            }
            break;
    }

    Console.WriteLine($"Ваш баланс:\nРубли = {rubles}\nДоллары = {dollars}\nЕвро = {euroCount}");
    Console.WriteLine("Хотите продолжить? (да/нет)");

    string answer = Console.ReadLine();

    if (answer == "нет") break;
}