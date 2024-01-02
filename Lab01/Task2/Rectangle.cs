namespace Task2
{
    class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle()
        {
            this._side1 = 0;
            this._side2 = 0;
        }

        public Rectangle(double sideA, double sideB)
        {
            if (sideA < 0 || sideB < 0)
            {
                throw new ArgumentException("Side length must be positive\n");
            }
            this._side1 = sideA;
            this._side2 = sideB;
        }

        private double CalculateArea(Rectangle rectangle)
        {
            return rectangle._side1 * rectangle._side2;
        }

        private double CalculatePerimeter(Rectangle rectangle)
        {
            return 2 * (rectangle._side1 + rectangle._side2);
        }

        public double getArea
        {
            get { return CalculateArea(this); }
        }

        public double getPerimeter
        {
            get { return CalculatePerimeter(this); }
        }
    };
}
