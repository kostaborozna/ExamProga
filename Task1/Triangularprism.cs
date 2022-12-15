namespace ConsoleApp37
{
    class Triangularprism : Triangle
    {
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double AreaTrianglePrism()
        {
            return PerimeterCalculation() * Height + 2 * AreaTriangle();
        }
    }
}
