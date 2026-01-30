int beeramid(int bonus, double price)
{
    if (bonus < 0 || static_cast<double>(bonus) / price < 1.0)
    {
        return 0;
    }

    int cans = static_cast<int>(static_cast<double>(bonus) / price);
    int lvl = 0;
    int currLvlCanNum = 1;
    for (int i = 2; ;++i)
    {
        if (cans - currLvlCanNum < 0)
        {
            return lvl;
        }

        cans -= currLvlCanNum;
        currLvlCanNum = i * i;
        lvl++;
    }
}
