using HexagonalSample.Application.DependencyResolvers;
using HexagonalSample.Persistence.DependencyResolvers;
using HexagonalSample.WebApi.Controllers;


var builder = WebApplication.CreateBuilder(args);

//Bu proje bizim Composition root, run => gercek uygulama...

//HexagonalSample.WebApi => Sadece bir Controller kütüphanesidir...Yani gizli ama gerçek API katmanı...Artık gerçek entry point sizin Host'unuz oldugu icin normal API katmanı projeniz cok daha serbestlik kazanır...

// Add services to the container.

builder.Services.AddRepositoryService();
builder.Services.AddDbContextService(builder.Configuration);
builder.Services.AddMediatRServices();
builder.Services.AddMapperServices();


builder.Services.AddControllers().AddApplicationPart(typeof(CategoryController).Assembly); //burası cok önemli.Cünkü Controller'larin bulundugu assembly'i tanıtıyoruz ki API cagrılarında Controller'lar nerede bulunabilsin...Burada Asp .Net Core'a sunu demiş oluyoruz : "HexagonalSample.WebApi icindeki Controllerları da kullan"
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

app.UseAuthorization();

app.MapControllers();

app.Run();
