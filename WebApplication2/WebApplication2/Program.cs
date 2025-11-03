
namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer(); // required for Swagger
            builder.Services.AddSwaggerGen();           // adds Swagger generator

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();     // generate Swagger JSON
                app.UseSwaggerUI();   // enable Swagger UI
            }

            app.UseAuthorization();
            app.MapControllers();
            app.Run();

        }
    }
}
