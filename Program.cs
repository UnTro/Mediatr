
using MediatrStudying.Controllers.DItesting;
using System.Text;
//using MediatrStudying.Controllers.Moisture;

namespace MediatrStudying
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IDItesting, DIclasses>();
            //---------------
            builder.Services.AddTransient<IMoisture, Moisture>();
           // builder.Services.AddTransient<IPressure, Pressure>();
            builder.Services.AddWeatherFeatureServices();
            builder.Services.AddTransient<Temperature>();
            //---------------
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {

                app.UseSwagger();
                app.UseSwaggerUI();

            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            
            //app.Run
            //(

            //    async context =>
            //{
            //    var sb = new StringBuilder();
            //    sb.Append("<h1>Все сервисы</h1>");
            //    sb.Append("<table>");
            //    sb.Append("<tr><th>Тип</th><th>Lifetime</th><th>Реализация</th></tr>");
            //    foreach (var svc in builder.Services)
            //    {
            //        sb.Append("<tr>");
            //        sb.Append($"<td>{svc.ServiceType.FullName}</td>");
            //        sb.Append($"<td>{svc.Lifetime}</td>");
            //        sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
            //        sb.Append("</tr>");
            //    }
            //    sb.Append("</table>");
            //    context.Response.ContentType = "text/html;charset=utf-8";
            //    await context.Response.WriteAsync(sb.ToString());
            //}
            
            //);
            app.Run();
        }
    }

}
