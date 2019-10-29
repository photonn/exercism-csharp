using System;

public class SpaceAge
{
    float seconds;
    public SpaceAge(int seconds)
    {
            this.seconds = seconds;
    }

    public double OnEarth()
    {
        return this.seconds / (1*365.25*24*3600);
    }

    public double OnMercury()
    {
        return this.seconds / (0.2408467*365.25*24*3600);
    }

    public double OnVenus()
    {
        return this.seconds / (0.61519726*365.25*24*3600);
    }

    public double OnMars()
    {
        return this.seconds / (1.8808158*365.25*24*3600);
    }

    public double OnJupiter()
    {
        return this.seconds / (11.862615*365.25*24*3600);
    }

    public double OnSaturn()
    {
        return this.seconds / (29.447498*365.25*24*3600);
    }

    public double OnUranus()
    {
        return this.seconds / (84.016846*365.25*24*3600);
    }

    public double OnNeptune()
    {
        return this.seconds / (164.79132*365.25*24*3600);
    }
}