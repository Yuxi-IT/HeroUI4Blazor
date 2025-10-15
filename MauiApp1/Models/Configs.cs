using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Configs
    {
        public static string ApplicationName = "HeroUI For Blazor";
        public static List<RouteModel> RouteList = [
            new(){
                    Name = "Home",
                    Href = "",
                    Icon = "Home"
                },
            new(){
                    Name = "Counter",
                    Href = "counter",
                    Icon = "Menu"
                },
            new(){
                    Name = "Weather",
                    Href = "weather",
                    Icon = "Database"
                }
            ];
    }
}
