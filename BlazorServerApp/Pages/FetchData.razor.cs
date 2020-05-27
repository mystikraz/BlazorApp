using BlazorServerApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Pages
{
    public partial class FetchData
    {
        //public WeatherForecastService ForecastService { get; }
        protected WeatherForecast[] forecasts;

        public FetchData()
        {
            //ForecastService = weatherForecastService;
        }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
