using BookCatalog.Services;                           //needed for IBookService & BookService
var builder = WebApplication.CreateBuilder(args);     //starts building app

// Add services to the container.
//builder.Services is the dependency injection container, a registry of things app knows how to create
builder.Services.AddControllers();      //for classes like BookController are discovered
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//when something ask for IBookService, give it BookService, create only 1 for whole life of the app
builder.Services.AddSingleton<IBookService, BookService>();

//closes registration and creates the app
//after this line u cannot add any services
var app = builder.Build();          

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUi(options =>
    {
        options.DocumentPath = "/openapi/v1.json";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
