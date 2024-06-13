using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
//using YourNamespace.Models; // �ھڧA���R�W�Ŷ��վ�

var builder = WebApplication.CreateBuilder(args);

// �]�m��Ʈw�s���r��
builder.Services.AddDbContext<NorthwindContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ���U����A��
builder.Services.AddControllers();

// �t�mSwagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

// �t�mHTTP�ШD�޹D
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
