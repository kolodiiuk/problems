#include <string>

bool XO(const std::string& str)
{
    int count = 0;
    for (const auto& curr : str)
    {
        if (curr == 'x' || curr == 'X')
        {
            count++;
        }
        else if (curr == 'o' || curr == 'O')
        {
            count--;
        }
    }

    return count == 0;
}
