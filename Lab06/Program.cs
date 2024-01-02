using System.Net;
using System.Text.Json.Serialization;
using Lab6;
using Newtonsoft.Json;

public class Program
{
    public static void Main()
    {

        string apiKey = "770c2c3365661b3c127f3a2657947aa4";

        List<Weather> weatherData = new List<Weather>();

        Random random = new Random();

        int count = 0;

        while (count < 50)
        {
            double latitude = random.NextDouble() * (90 - (-90)) + (-90);
            double longitude = random.NextDouble() * (180 - (-180)) + (-180);

            string url = "https://api.openweathermap.org/data/2.5/weather?lat=" + latitude.ToString() + "&" +
                         "lon=" + longitude.ToString() + "&exclude=minutely,hourly,daily,alerts&" +
                         "units=metric&appid=" + apiKey;

            // Create URL request to API openweathermap.org with generated coordinates
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);

            // Get response with weather data
            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            string response;
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
                WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                if (weatherResponse.Name != "" || weatherResponse.Name != "")
                {
                    // Convert got data to structure Weather and add it to weatherData
                    Weather w = new Weather(weatherResponse);
                    w.Temp = Math.Round(w.Temp, 2);
                    weatherData.Add(w);
                    w.Print();
                    count++;
                }
            }
        }

        Console.WriteLine();

        // Country with maximal temperature
        var countryWithMaxTemp = weatherData.MaxBy(w => w.Temp).Country;
        Console.Write("Country with maximal temperature: " + countryWithMaxTemp + " ");
        var maxTemp = weatherData.MaxBy(w => w.Temp).Temp;
        Console.Write("(" + maxTemp + " C)\n\n");

        // Country with minimal temperature
        var countryWithMinTemp = weatherData.MinBy(w => w.Temp).Country;
        Console.Write("Country with minimal temperature: " + countryWithMinTemp);
        var minTemp = weatherData.MinBy(w => w.Temp).Temp;
        Console.Write("(" + minTemp + " C)\n\n");

        // Average temperature in the world
        var averageTemp = weatherData.Average(w => w.Temp);
        Console.WriteLine("Average temperature in the world: " + averageTemp + "\n");

        // Number of countries in collection
        var countryCount = weatherData.Select(w => w.Country).Distinct().Count();
        Console.WriteLine("Number of countries in collection: " + countryCount + "\n");

    // The first found country and name of place with suitable description
        var firstMatch = weatherData.FirstOrDefault(w => w.Description == "clear sky" || w.Description == 
            "rain" || w.Description == "few clouds");
        Console.WriteLine($"The first found country and name of place with suitable description: " +
                          $"{firstMatch.Country}, {firstMatch.Name} with {firstMatch.Description}");
        
    }
}