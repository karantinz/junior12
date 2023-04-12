float rubles = 1000f;
float dollars = 1000f;
float euroCount = 1000f;

float rubToUsd = 0.014f;
float rubToEur = 0.011f;
float usdToEur = 0.85f;
float usdToRub = 73.89f;
float eurToUsd = 1.18f;
float eurToRub = 87.64f;

bool programExecution = true;

string rubleName = "Рубли";
string dollarsName = "Доллары";
string euroName = "Евро";

const int ConvertFromRubles = 1;
const int ConvertFromDollars = 2;
const int ConvertFromEuros = 3;

const string ExitYes = "да";
const string ExitNo = "нет";

Console.WriteLine("Конвертор валют");

while (programExecution)
{
    Console.WriteLine($"Ваш баланс:\n{rubleName} = {rubles}\n{dollarsName} = {dollars}\n{euroName} = {euroCount}");

    Console.WriteLine("Выбурите валюту, которую хотите конвертировать");
    Console.WriteLine($"1.{rubleName}\n2.{dollarsName}\n3.{euroName}");

    int fromCurrency = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Выбурите валюту, в которую хотите конвертировать");
    Console.WriteLine($"1.{rubleName}\n2.{dollarsName}\n3.{euroName}");

    int toCurrency = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите сумму, которую вы хотите конвертировать");

    float valueToConvert = float.Parse(Console.ReadLine());

    switch (fromCurrency)
    {
        case ConvertFromRubles:
            switch (toCurrency)
            {
                case ConvertFromDollars:
                    rubles -= valueToConvert;
                    dollars += valueToConvert * rubToUsd;
                    break;
                case ConvertFromEuros:
                    rubles -= valueToConvert;
                    euroCount += valueToConvert * rubToEur;
                    break;
            }
            break;
        case ConvertFromDollars:
            switch (toCurrency)
            {
                case ConvertFromRubles:
                    dollars -= valueToConvert;
                    rubles += valueToConvert * usdToRub;
                    break;
                case ConvertFromEuros:
                    dollars -= valueToConvert;
                    euroCount += valueToConvert * usdToEur;
                    break;
            }
            break;
        case ConvertFromEuros:
            switch (toCurrency)
            {
                case ConvertFromRubles:
                    euroCount -= valueToConvert;
                    rubles += valueToConvert * eurToRub;
                    break;
                case ConvertFromDollars:
                    euroCount -= valueToConvert;
                    dollars += valueToConvert * eurToUsd;
                    break;
            }
            break;
    }

    Console.WriteLine($"Ваш баланс:\n{rubleName} = {rubles}\n{dollarsName} = {dollars}\n{euroName} = {euroCount}");
    Console.WriteLine($"Хотите продолжить? ({ExitYes}/{ExitNo})");

    string answer = Console.ReadLine();

    if (answer == ExitNo) programExecution = false;
}