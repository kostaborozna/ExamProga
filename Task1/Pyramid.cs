class Pyramid : Triangle
{
    private int _height;

    public int Height
    {
        get { return _height; }
        set { _height = value; }
    }

    public double AreaPyromid()
    {
        double AreaSite = 0.5 * Height * PerimeterCalculation();
        double AreaBok = (Math.Pow(SiteA,2) * Math.Sqrt(3)) / 4;

        return AreaSite+AreaBok;
    }

}

