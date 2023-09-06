using TestTask.Services;
using TestTask.Services.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ISum, SumModuloService>();
builder.Services.AddTransient<ICheckingPalindrome, PalindromeService>();
builder.Services.AddTransient<ISort, NumbersSortService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
