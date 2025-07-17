using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Globalization;

namespace weather
{
    class Program
    {
        static async Task GetWeather(string inputLocation)
        {
            var location = inputLocation;

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/" + location + "%2C%20ZA?unitGroup=us&key=ZPERH27GV6NP4ZL3V9YYRFH8B&contentType=json\r\n");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();

            dynamic weather = JsonConvert.DeserializeObject(body);

            Console.Clear();
            DisplayArt();

            string weatherLocation = weather.address;
            Console.WriteLine("Location : "+ weatherLocation);
            Console.WriteLine("============================================");

            foreach (var day in weather.days)
            {
                string weather_date = day.datetime;
                DateTime parsedDate = DateTime.ParseExact(weather_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string dayOfWeek = parsedDate.DayOfWeek.ToString();
                string longDate = parsedDate.ToString("D", CultureInfo.InvariantCulture);
                string weather_desc = day.description;
                double weather_tmax = (day.tempmax-32)/1.8;
                double weather_tmin = (day.tempmin-32)/ 1.8;
                weather_tmax = Math.Round(weather_tmax, 2);
                weather_tmin = Math.Round(weather_tmin, 2);

                Console.WriteLine("Forecast for date: " + dayOfWeek);
                Console.WriteLine("General conditions: " + weather_desc);
                Console.WriteLine("The high temperature will be " + weather_tmax + "°C");
                Console.WriteLine("The low temperature will be: " + weather_tmin + "°C");
                Console.WriteLine();
            }
        }

        static string StringManipulation(string weather)
        {
            weather = weather.ToLower();
            char firstChar = weather[0];
            string firstLetterU = firstChar.ToString().ToUpper();
            weather = weather.Remove(0,1);
            weather = firstLetterU + weather;
            return weather;
        }

        static void DisplayArt()
        {
            Console.Write("============================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" 
__          __        _   _               
\ \        / /       | | | |              
 \ \  /\  / /__  __ _| |_| |__   ___ _ __ 
  \ \/  \/ / _ \/ _` | __| '_ \ / _ \ '__|
   \  /\  /  __/ (_| | |_| | | |  __/ |   
    \/  \/ \___|\__,_|\__|_| |_|\___|_|   
            ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("============================================");
        }

        static async Task Main(string[] args)
        {
            DisplayArt();
            Console.WriteLine("Please enter the city name :");
            string InputWeather = Console.ReadLine();

            InputWeather = StringManipulation(InputWeather);
            await GetWeather(InputWeather);
            Console.ReadLine();
        }
    }
}
