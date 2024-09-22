
namespace Verk1
{
      class Program
     
     {
         static void Main()
         {
             /* List<double> numbers = new List<double>();
              string input;

              while (true)
              {
                  Console.WriteLine("Enter a number: ");
                  input = Console.ReadLine();

                  if (string.IsNullOrEmpty(input))
                      break;

                  if (double.TryParse(input, out double number))
                  {
                      numbers.Add(number);
                  }
                  else
                  {
                      Console.WriteLine("Please enter a valid number: ");
                  }
              }

              if (numbers.Count > 0)
              {
                  double largest = numbers[0];
                  double smallest = numbers[0];

                  foreach (double num in numbers)
                  {
                      if (num > largest)
                          largest = num;
                      if (num < smallest)
                          smallest = num;
                  }
                  Console.WriteLine($"The largest number is: {largest}");
                  Console.WriteLine($"The smallest number is: {smallest}");
              }
              else
              {
                  Console.WriteLine("Please enter a number: ");
                  */
             
                  double temperature = 0;
                  double humidity = 0;
                  char scale = 'C';

                  while (true)
                  {
                      Console.WriteLine("Please enter a temperature followed by the scale(example: 5C or 96F): ");
                      string input = Console.ReadLine()!;

                      if (!string.IsNullOrEmpty(input) && (input.EndsWith("C") || input.EndsWith("F")))
                      {
                          scale = input[input.Length -1];

                          string tempPart = input.Substring(0, input.Length - 1);

                          if (double.TryParse(tempPart, out temperature))
                          {
                              if ((scale == 'C' && temperature >= -60 && temperature <= 60) ||
                                  (scale == 'F' && temperature >= -76 && temperature <= 140))
                              {
                                  break;
                              }
                              else
                              {
                                  Console.WriteLine("Invalid temperature, try again!");
                              }
                          }
                      }
                      else
                      {
                          Console.WriteLine("Invalid input format, try again!");
                      }
                  }

                  while (true)
                  {
                      Console.WriteLine("Enter a humidity level(0-100): ");
                      string humidityInput = Console.ReadLine()!;

                      if (double.TryParse(humidityInput, out humidity) && humidity >= 0 && humidity <= 100)
                      {
                          break;
                      }
                      else
                      {
                          Console.WriteLine("Invalid humidity, try again!");
                      }
                  }
                  WeatherData weather = new WeatherData(temperature, humidity, scale);

                  Console.WriteLine("\nWeather data:");
                  weather.DisplayWeatherData();

                  Console.WriteLine("\nDo you want to convert the temperature? (y/n): ");
                  string convertChoice = Console.ReadLine()!;

                  if (convertChoice.ToLower() == "y")
                  {
                      weather.Convert();
                      Console.WriteLine("\nConverted!");
                      weather.DisplayWeatherData();
                  }
                  else
                  {
                      Console.WriteLine("\n NO CONVERT!");
                  } 
         }

     }

}

