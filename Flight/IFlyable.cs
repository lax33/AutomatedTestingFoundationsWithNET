namespace Flight
{
    internal interface IFlyable
    {
        double FlyTo(Coordinate newPoint);

        double GetFlyTime(Coordinate newPoint);
    }
}