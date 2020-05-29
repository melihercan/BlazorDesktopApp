using WebWindows.Blazor;
using System;

namespace BlazorDesktopApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/SteveSandersonMS/WebWindow/issues/109
            ComponentsDesktop.Run<Startup>("My Blazor App", "wwwroot/index.html");
        }
    }
}
