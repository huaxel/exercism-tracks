public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = x*x + y*y;

        return distance switch
        {
            > 100 =>  0,
            > 25 =>  1,
            > 1 => 5,
            _ => 10
        };
    }
}
