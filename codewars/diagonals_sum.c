#include <stddef.h>

int sum_diagonals(size_t n, const int matrix[n][n]) {
    int res = 0;
    if (n == 1) return matrix[0][0] + matrix[0][0];

    for (size_t i = 0; i < n; ++i) {
        for (size_t j = 0; j < n; ++j) {
            if (i == j) {
                res += matrix[i][j];
            }

            if (i + j == n - 1) {
                res += matrix[i][j];
            }
        }
    }

    return res;
}
