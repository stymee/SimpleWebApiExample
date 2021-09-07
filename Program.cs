var builder = WebApplication.CreateBuilder(args);

// inject service
builder.Services.AddSingleton<DogsReader>();

// build
var app = builder.Build();

// default stuff
if (app.Environment.IsDevelopment()) { app.UseDeveloperExceptionPage(); }

// endpoints
app.MapGet("/", () => "Hello World!");

app.MapGet("/dogs", (string? name, string? breed, DogsReader reader) => reader.GetDogs(name, breed));
app.MapGet("/dogs/{id}", (string id, DogsReader reader) => reader.GetDogByName(id));

// run app
app.Run();
