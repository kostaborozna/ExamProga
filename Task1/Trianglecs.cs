class Triangle
{
    private int _sitea;

    private int _siteb;

    private int _sitec;

    public int SiteA
    {
        get { return _sitea; }
        set { _sitea = value; }
    }

    public int SiteB
    {
        get { return _siteb; }
        set { _siteb = value; }
    }

    public int SiteC
    {
        get { return _sitec; }
        set { _sitec = value; }
    }

    public bool Check()
    {
        if ((SiteA + SiteB <= SiteC) || (SiteA + SiteC <= SiteB) || (SiteB + SiteC <= SiteA))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public int PerimeterCalculation()
    {
        int P = SiteA + SiteB + SiteC;
        return P;
    }

    public double AreaTriangle()
    {
        double p = 0.5 * (SiteA + SiteB + SiteC);
        return Math.Sqrt(p * ((p - SiteA) * (p - SiteB) * (p - SiteC)));
    }
}

