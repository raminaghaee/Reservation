using PoolUI;
using PoolUI.IOC;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureServices().ConfigurePipeline();


app.Run();
