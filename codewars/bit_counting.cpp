unsigned int countBits(unsigned long long n){
    if (n == 0) return 0;
    unsigned int c = 0;
    while (n != 0) {
        if (n & 1) {
            c++;
        }
        n = n >> 1;
    }

    return c;
}

