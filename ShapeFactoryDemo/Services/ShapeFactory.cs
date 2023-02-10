using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo.Services
{
    public interface IShapeFactory
    {
        IShape GetShape(ShapeEnum shapeEnum);
    }

    public class ShapeFactory : IShapeFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ShapeFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IShape GetShape(ShapeEnum shapeEnum)
        {
            switch (shapeEnum)
            {
                case ShapeEnum.Cube:
                    return (IShape)_serviceProvider.GetService(typeof(Cube));
                case ShapeEnum.Sphere:
                    return (IShape)_serviceProvider.GetService(typeof(Sphere));
                default:
                    throw new ArgumentException(nameof(shapeEnum), $"Shape {shapeEnum} is not available yet.");


            }
        }
    }
}
