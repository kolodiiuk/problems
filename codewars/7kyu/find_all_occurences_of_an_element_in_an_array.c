#include <stdlib.h>

size_t *find_all(size_t a, const int array[a], int number, size_t *z) {
    *z = 0;
    for (int i = 0; i < a; i++) {
        if (array[i] == number) {
            (*z)++;
        }
    }
    size_t* res = (size_t*)malloc(sizeof(size_t) * *z);
    size_t* res_ptr = res;
    for (int i = 0; i < a; i++) {
        if (array[i] == number) {
            *res_ptr++ = i;
        }
    }

    return res;
}