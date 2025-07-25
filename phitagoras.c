#include <stdio.h>
#include <math.h>

int main(void) {
    double a, b;
    printf("Enter the two legs (a b): ");
    if (scanf("%lf %lf", &a, &b) != 2 || a <= 0 || b <= 0) {
        printf("Invalid input.\n");
        return 1;
    }

    double c = sqrt(a * a + b * b);
    printf("Hypotenuse = %.6f\n", c);
    return 0;
}
