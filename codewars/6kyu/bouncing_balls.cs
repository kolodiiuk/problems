public class BouncingBall
{

    public static int bouncingBall(double h, double bounce, double window)
    {
        if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
        {
            return -1;
        }

        var count = 1;
        var pos = h * bounce;
        while (pos > window)
        {
            pos = pos * bounce;
            count += 2;
        }

        return count;
    }
}
