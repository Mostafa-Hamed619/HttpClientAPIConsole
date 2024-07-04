using AspNetTopics;
using AspNetTopics.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add the config.json file to the configuation
builder.Configuration.AddJsonFile("config.json");
builder.Services.AddLogging(cfg =>
{
    cfg.AddDebug();
});

builder.Services.Configure<AttachmentOptions>(builder.Configuration.GetSection("Attachments"));

//var attachmentOptions = builder.Configuration.GetSection("Attachments").Get<AttachmentOptions>();
//builder.Services.AddSingleton(attachmentOptions);


//var attachmentOptions = new AttachmentOptions();
//builder.Configuration.GetSection("Attachments").Bind(attachmentOptions);
//builder.Services.AddSingleton(attachmentOptions);

builder.Services.AddDbContext<MagicVillaContext>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
