public class ProdFib
{
    public static ulong[] productFib(ulong prod)
    {
        ulong fibI = 1;
        ulong fibIMinus1 = 0;
        ulong j = 1;
        while (j <= prod && fibI * fibIMinus1 < prod)
        {
            ulong t = fibI;
            fibI = fibIMinus1 + fibI;
            fibIMinus1 = t;

            j++;
        }

        return fibI * fibIMinus1 == prod ? new ulong[] { fibIMinus1, fibI, 1 } : new ulong[] {fibIMinus1, fibI, 0};
    }
}
