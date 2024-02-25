using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<IOContext>();

builder.Services.AddScoped<ICategoryDal,CategoryDal>();
builder.Services.AddScoped<ICourseDal,CourseDal>();
builder.Services.AddScoped<IInstructorDal,InstructorDal>();

var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Index}"
    );

app.Run();
