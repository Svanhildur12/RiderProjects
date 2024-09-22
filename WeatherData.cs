namespace Verk1
{
    internal class WeatherData
    {
        private double _temperature;
        private double _humidity;
        private char _scale;

        public double Temperature
        {
            set
            {
                if ((_scale == 'C' && value >= -60 && value <= 60) || (_scale == 'F' && value >= -76 && value <= 140))
                {
                    _temperature = value;
                }
                else
                {
                    Console.WriteLine("Unrealistic temperature");
                }
            }
        }

        public double Humidity
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _humidity = value;
                }
                else
                {
                    Console.WriteLine("Humidity should be between 0% and 100%");
                }
            }
        }

        public char Scale
        {
            set
            {
                if (value == 'C' || value == 'F')
                {
                    _scale = value;
                }
                else
                {
                    Console.WriteLine("Scale should be 'C' or 'F'");
                }
            }
        }

        public void Convert()
        {
            if (_scale == 'C')
            {
                _temperature = (_temperature * 9 / 5) + 32;
                _scale = 'F';
            }
            else if (_scale == 'F')
            {
                _temperature = (_temperature - 32) * 5 / 9;
                _scale = 'C';
            }
        }
        public WeatherData(double temp, double humid, char scale)
        {
            Scale = scale;
            Temperature = temp;
            Humidity = humid;
        }
        
        public void DisplayWeatherData()
        {
            Console.WriteLine($"Temperature: {_temperature}°{_scale}");
            Console.WriteLine($"Humidity: {_humidity}%");
        }
    }
    }
    
