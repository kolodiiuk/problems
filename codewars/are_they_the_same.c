#include <stdbool.h>
#include <stddef.h>
#include <stdlib.h>

bool comp(const int a[/*n*/], const int b[/*n*/], size_t n)
{
    if (a == NULL || b == NULL) {
        return false;
    }
    int* c = (int*)malloc(sizeof(int) * n);
    for (int i = 0; i < n; i++) {
        c[i] = a[i] * a[i];
    }
    for (int i = 0; i < n; i++) {
        bool flag = 0;
        for (int j = 0; j < n; j++) {
            if (b[i] == c[j]) {
                flag = 1;
                c[j] = -1;
                break;
            }
        }
        if (flag == 0) {
            free(c);
            return false;
        }
    }

    free(c);
    return true;
}