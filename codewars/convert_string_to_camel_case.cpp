#include <string>

std::string to_camel_case(std::string text)
{
    size_t l = text.length();
    if (l <= 1) return text;
    std::string res;
    for (size_t i = 0; i < l;)
    {
        const char *cc = &text[i];
        switch (*cc)
        {
            case '_':
            case '-':
            {
                if (text[i + 1] >= 97 && text[i + 1] <= 122)
                {
                    res.push_back(static_cast<char>(static_cast<int>(*(++cc)) - 32));
                }
                else if (text[i + 1] >= 65 && text[i + 1] <= 90)
                {
                    res.push_back(*(++cc));
                }

                i += 2;
                break;
            }
            default:
            {
                res.push_back(*cc);
                ++i;
            }
        }
    }

    return res;
}
