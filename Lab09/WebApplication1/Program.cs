using System.Globalization;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;
using WebApplication1;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapGet("/get-weather", async (HttpContext context) =>
{
    string lat = context.Request.Query["latitude"];
    string lon = context.Request.Query["longitude"];
    string apiKey = "770c2c3365661b3c127f3a2657947aa4";
    
    string url = "https://api.openweathermap.org/data/2.5/weather?lat=" + lat.ToString() + "&" +
                 "lon=" + lon.ToString() + "&exclude=minutely,hourly,daily,alerts&" +
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
            return w;
        }
        else
        {
            Weather w = new Weather();
            return w;
        }
    }
}).WithName("GetWeather");

app.MapGet("get-cities", () =>
{
    List<City> result = new List<City>();

    if (File.Exists("/home/thematrix/CSharpProjects/Lab9/WebApplication1/city.txt"))
    {
        

        using (StreamReader reader = new StreamReader("/home/thematrix/CSharpProjects/Lab9/WebApplication1/city.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split( ',');
                result.Add(new City(data[0], data[1], data[2]));
            }
        } 
        
    }
    
    return result;
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();