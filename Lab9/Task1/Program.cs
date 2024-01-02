﻿using System.Globalization;
using System.Net;

namespace Task1
{
    class Program
    {
        static async Task Main()
        {
            string pathToTickerFile = "/home/thematrix/CSharpProjects/Lab9/Task1/ticker.txt";

            // create list of tickers from ticker.txt
            string[] tickers = ReadFile(pathToTickerFile);

            // get today time and 1 year ago in UNIX
            long todayUNIX = DateTimeOffset.Now.ToUnixTimeSeconds();
            long todayYearAgoUNIX = DateTimeOffset.Now.AddYears(-1).ToUnixTimeSeconds();

            List<Task> tasks = new List<Task>();

            // создание потоков
            foreach (var ticker in tickers)
            {
                WebSurfer ws = new WebSurfer(ticker, todayYearAgoUNIX, todayUNIX);
                tasks.Add(Task.Run(() => ws.GetData()));
            }

            await Task.WhenAll(tasks);
        }

        // read txt file by lines (every line - element of List)
        static string[] ReadFile(string pathToFile)
        {
            string[] result;
            using (StreamReader streamReader = new StreamReader(pathToFile))
            {
                string content = streamReader.ReadToEnd();
                string[] lines = content.Split('\r');
                for (int i = 1; i < lines.Length; i++)
                {
                    lines[i] = lines[i][1..];
                }
                result = lines;
            }

            return result;
        }
    }

    record class WebSurfer(string Ticker, long StartTime, long EndTime)
    {
        private static object locker = new();

        public void GetData()
        {
            string url =
                $"https://query2.finance.yahoo.com/v7/finance/download/{Ticker}?period1={StartTime}&period2={EndTime}&interval=1d&events=history&includeAdjustedClose=true";

            using (WebClient client = new WebClient())
            {
                try
                {
                    string csvData = client.DownloadString(url);

                    string[] lines = csvData.Split('\n');
                    double average = 0;
                    int days = 0;

                    foreach (var line in lines[1..^1]) // skip header and last empty lines
                    {
                        string[] elems = line.Split(',');

                        if (elems.Length > 5)
                        {
                            NumberFormatInfo provider = new NumberFormatInfo();
                            provider.NumberDecimalSeparator = ".";
                            provider.NumberGroupSeparator = ",";
                            double high = Convert.ToDouble(elems[2], provider);
                            double low = Convert.ToDouble(elems[3], provider);

                            average += (high + low) / 2;
                            days++;
                        }
                    }

                    average /= days;
                    string resultLine = $"{Ticker} : {average}";

                    lock (locker)
                    {
                        using (StreamWriter streamWriter =
                               new StreamWriter("/home/thematrix/CSharpProjects/Lab9/Task1/output.txt", true))
                        {
                            streamWriter.WriteLine(resultLine);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error fetching data for {Ticker}: {e.Message}");
                    return;
                }
            }
        }
    }
}
