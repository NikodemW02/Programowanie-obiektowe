using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Wybierz opcję kalkulatora");
            Console.WriteLine("1. Oblicz sumę");
            Console.WriteLine("2. Oblicz różnicę");
            Console.WriteLine("3. Oblicz iloczyn");
            Console.WriteLine("4. Oblicz iloraz");
            Console.WriteLine("5. Oblicz potęgę");
            Console.WriteLine("6. Oblicz pierwiastek");
            Console.WriteLine("7. Oblicz funkcje trygonometryczne");
            Console.WriteLine("8. Wyjdź");

            Console.Write("Wybierz opcję: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double sum = num1 + num2;
                    Console.WriteLine($"Suma: {sum}");
                    break;

                case 2:
                    Console.Write("Podaj pierwszą liczbę: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    num2 = double.Parse(Console.ReadLine());
                    double difference = num1 - num2;
                    Console.WriteLine($"Różnica: {difference}");
                    break;

                case 3:
                    Console.Write("Podaj pierwszą liczbę: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    num2 = double.Parse(Console.ReadLine());
                    double product = num1 * num2;
                    Console.WriteLine($"Iloczyn: {product}");
                    break;

                case 4:
                    Console.Write("Podaj pierwszą liczbę: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 != 0)
                    {
                        double quotient = num1 / num2;
                        Console.WriteLine($"Iloraz: {quotient}");
                    }
                    else
                    {
                        Console.WriteLine("Nie dzieli się przez zero!.");
                    }
                    break;

                case 5:
                    Console.Write("Podaj liczbę: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj wykładnik potęgi: ");
                    double exponent = double.Parse(Console.ReadLine());
                    double power = Math.Pow(num1, exponent);
                    Console.WriteLine($"Potęga: {power}");
                    break;

                case 6:
                    Console.Write("Podaj liczbę do pierwiastkowania: ");
                    num1 = double.Parse(Console.ReadLine());
                    if (num1 >= 0)
                    {
                        double squareRoot = Math.Sqrt(num1);
                        Console.WriteLine($"Pierwiastek kwadratowy: {squareRoot}");
                    }
                    else
                    {
                        Console.WriteLine("Nie można obliczyć pierwiastka z liczby ujemnej.");
                    }
                    break;

                case 7:
                    Console.Write("Podaj kąt w radianach: ");
                    double angle = double.Parse(Console.ReadLine());
                    double sinValue = Math.Sin(angle);
                    double cosValue = Math.Cos(angle);
                    double tanValue = Math.Tan(angle);
                    Console.WriteLine($"Sin({angle}) = {sinValue}");
                    Console.WriteLine($"Cos({angle}) = {cosValue}");
                    Console.WriteLine($"Tan({angle}) = {tanValue}");
                    break;

                case 8:
                    Console.WriteLine("Koniec programu.");
                    return;

                default:
                    Console.WriteLine("Zła opcja, jeszcze raz.");
                    break;
            }
        }
    }
}
