using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo.Services
{
    public interface IShapeCalculationService
    {
        void CalculateShapeMesurements();
    }

    public class ShapeCalculationService : IShapeCalculationService
    {
        private readonly IShapeFactory _shapeFactory;
        private IShape _shape;
        public ShapeCalculationService(IShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }
        public void CalculateShapeMesurements()
        {
            _shape = GetShapeFromUser();
            _shape.GetInputValues();
            _shape.DisplaySurfaceArea();
            _shape.DisplayVolume();
        }

        private IShape GetShapeFromUser()
        {
            Console.WriteLine("Enter one choise from below:");
            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Sphere");

            var choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    return _shapeFactory.GetShape(ShapeEnum.Cube);
                case 2:
                    return _shapeFactory.GetShape(ShapeEnum.Sphere);
                default:
                    throw new ArgumentException("Invalid input.");
            }

        }
    }
}
