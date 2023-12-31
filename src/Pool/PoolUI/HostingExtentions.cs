using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolBL.IContext;
using PoolDA;
using PoolDA.Contexts;
using PoolUI.IOC;

namespace PoolUI;

public static class HostingExtentions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();

        builder.Services.AddDbContext<PoolDbContext>(options =>
                  options.UseSqlServer(builder.Configuration.GetConnectionString("PoolConnectionString")));
        builder.Services.IsRegister();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        //unity Register


        return builder.Build();
    }
    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();
        return app;
    }
}
