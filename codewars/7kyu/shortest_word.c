#include <sys/types.h>
#include <string.h>

ssize_t find_short(const char *s)
{
    ssize_t shortestLength = 10000000;
    ssize_t currShortest = 0;

    const char *sPtr = s;
  
    while (*sPtr != '\0')
    {
        if (*sPtr == ' ')
        {
            if (currShortest < shortestLength) shortestLength = currShortest;
          
            currShortest = 0;
        }
      
        else currShortest++;
        
        ++sPtr;
    }
  
    return shortestLength > currShortest ? currShortest : shortestLength;
}
