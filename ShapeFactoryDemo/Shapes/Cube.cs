namespace ShapeFactoryDemo.Shapes
{
    public class Cube : IShape
    {
        public decimal Side { get; set; }

        public void GetInputValues()
        {
            Console.WriteLine("Side= ");
            Side = decimal.Parse(Console.ReadLine());
        }

        public void DisplaySurfaceArea()
        {
            Console.WriteLine("Surface area of the cube is: " + (6 * Side * Side));
        }

        public void DisplayVolume()
        {
            Console.WriteLine("Volume of the cube is: " + (Side * Side * Side));
        }
    }
}
