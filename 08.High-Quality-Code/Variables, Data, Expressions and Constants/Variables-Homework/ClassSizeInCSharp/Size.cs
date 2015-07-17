namespace ClassSizeInCSharp
{
    using System;
    public class Size
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Size GetRotatedSize(double angleOfRotation)
        {
            double newWidth = GetSizeAfterSinAndCos(angleOfRotation, this.Width, this.Height);
            double newHeight = GetSizeAfterSinAndCos(angleOfRotation, this.Height, this.Width);
            
            return new Size(newWidth, newHeight);
        }

        private static double GetSizeAfterSinAndCos(double angle, double sizeWithCos, double sizeWithSin)
        {
            double result = Math.Abs(Math.Cos(angle)) * sizeWithCos + 
                            Math.Abs(Math.Sin(angle)) * sizeWithSin;
            
            return result;
        }

        public override string ToString()
        {
            return String.Format("(Width: {0:F2}, Height: {1:F2})", this.Width, this.Height);
        }
    }
}
