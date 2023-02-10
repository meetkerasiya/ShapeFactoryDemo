using ShapeFactoryDemo.Services;
using ShapeFactoryDemo.Shapes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var serviceProvider=new ServiceCollection()
    .AddTransient<IShapeFactory,ShapeFactory>()
    .AddTransient<IShapeCalculationService,ShapeCalculationService>()
    .AddScoped<Sphere>()
    .AddScoped<IShape,Sphere>(s=> (Sphere)s.GetServices<Sphere>())
    .AddScoped<Cube>()
    .AddScoped<IShape,Cube>(s=> (Cube)s.GetServices<Cube>())
    .BuildServiceProvider();

var service=serviceProvider.GetService<IShapeCalculationService>();
service.CalculateShapeMesurements();
    

app.Run();
