var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Probando si se puede subir commit...
//Probando tambien 
//Eli, probando sonido 123...
//alitas de barbacoa
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
