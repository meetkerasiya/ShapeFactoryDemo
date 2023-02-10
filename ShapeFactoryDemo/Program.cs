using ShapeFactoryDemo.Services;
using ShapeFactoryDemo.Shapes;

var builder = WebApplication.CreateBuilder(args);


//var serviceProvider=new ServiceCollection()
//    .AddTransient<IShapeFactory,ShapeFactory>()
//    .AddTransient<IShapeCalculationService,ShapeCalculationService>()
//    .AddScoped<Sphere>()
//    .AddScoped<IShape,Sphere>(s=> (Sphere)s.GetServices<Sphere>())
//    .AddScoped<Cube>()
//    .AddScoped<IShape,Cube>(s=> (Cube)s.GetServices<Cube>())
//    .BuildServiceProvider();

//var service=serviceProvider.GetService<IShapeCalculationService>();
//service.CalculateShapeMesurements();


var services=builder.Services;
services.AddTransient<IShapeCalculationService, ShapeCalculationService>();
services.AddTransient<IShapeFactory,ShapeFactory>();
services.AddScoped<Sphere>();
services.AddScoped<IShape, Sphere>(s => (Sphere)s.GetServices<Sphere>());
services.AddScoped<IShape, Cube>(s => (Cube)s.GetServices<Cube>());
services.AddScoped<Cube>();
var calculate = services.BuildServiceProvider().GetService<IShapeCalculationService>();
calculate.CalculateShapeMesurements();
var app = builder.Build();
app.Run();
