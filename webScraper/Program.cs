using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper
{
    class Program 
    {
        static void Main(string[] args){
            // send get request to address below
            string url = "https://weather.com/weather/today/l/454e6bccb0012fca165ef0424e228c5d03e592d6e05a8463677f1ad42a9c4beb";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // get temp
            var temperatureElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='CurrentConditions--tempValue--MHmYY']");
            var temperature = temperatureElement.InnerText.Trim();

            Console.WriteLine($"Temperature: {temperature}");

            // get conditions
  var conditionElement = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var condition = conditionElement.InnerText.Trim();

            Console.WriteLine($"Conditions: {condition}");
            //get location
            var locationElement = htmlDocument.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var location = locationElement.InnerText.Trim();

            Console.WriteLine(location);
        }
    }
}
