using BlazorServerApp.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Pages
{
    public class FetchDataBase : ComponentBase
    {
        public WeatherForecastService ForecastService { get; }
        protected WeatherForecast[] forecasts;

        public FetchDataBase()
        {
            ForecastService = new WeatherForecastService();
        }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
