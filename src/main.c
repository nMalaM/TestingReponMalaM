#include "../include/fibonacci.h"
#include <stdio.h>

// Declare the fibonacci function from fibonacci.c
unsigned long long fibonacci(int n);

int main(void) {
    int n;
    printf("Enter n (0 to 50 recommended): ");
    if (scanf("%d", &n) != 1 || n < 0) {
        printf("Invalid input.\n");
        return 1;
    }

    printf("Fibonacci(%d) = %llu\n", n, fibonacci(n));
    return 0;
}