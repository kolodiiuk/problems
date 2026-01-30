using System;

public class User
{
    public int rank = -8;
    public int progress;

    public void incProgress(int actRank)
    {
        if (rank == 8) return;
        switch (actRank)
        {
            case > 8 or < -8 or 0: throw new ArgumentException();
        }

        int newProgress = progress;

        if (actRank == rank)
        {
            newProgress += 3;
        }
        else if (actRank == rank - 1 || (actRank == -1 && rank == 1))
        {
            newProgress++;
        }
        else if (rank - actRank >= 2)
        {
            return;
        }
        else
        {
            int diffCoef = 0;
            if (!(actRank > 0 && rank < 0))
            {
                diffCoef = (actRank - rank) * (actRank - rank);
            }
            else
            {
                diffCoef = (actRank - rank - 1) * (actRank - rank - 1);
            }

            newProgress += 10 * diffCoef;
        }

        if (newProgress >= 100)
        {
            if (rank == 8)
            {
                return;
            }

            int diffInRanks = newProgress - 100;
            if (diffInRanks < 100)
            {
                rank = rank switch
                {
                    -1 => 1,
                    _ => rank + 1
                };

                progress = newProgress - 100;
                if (rank == 8) progress = 0;


                return;
            }
            else
            {
                while (newProgress >= 100)
                {
                    if (rank < 8)
                    {
                        rank++;
                    }
                    else
                    {
                        progress = 0;

                        return;
                    }

                    newProgress -= 100;
                }
            }

            progress = rank == 8 ? 0 : newProgress;
        }
        else
        {
            progress = rank == 8 ? 0 : newProgress;
        }
    }
}
