var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseDirtyTrackedSessions();

var app = builder.Build();

//configure the HTTP requet pipeline.
app.MapCarter();

app.Run();
