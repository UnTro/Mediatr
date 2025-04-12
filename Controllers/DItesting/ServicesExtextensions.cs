namespace MediatrStudying.Controllers.DItesting
{
    public  static class ServicesExtetensions
    {
        public static IServiceCollection AddWeatherFeatureServices(this IServiceCollection services)
        {
            services.AddTransient<IPressure, Pressure>();
            
            return services;
        }


    }
}
