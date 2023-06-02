#include <stdio.h>
#include <math.h>


void main(void) {
    float X;
    int Y;

    printf("Ingrese el valor de Y: ");
    scanf("%d", &Y);

    if (Y < 0 || Y > 50)
        X = 0;
    else if (Y <= 10)
        X = 4.0 / Y - Y;
    else if (Y <= 25)
        X = pow(Y, 3) - 12;
    else
        X = pow(Y, 2) + pow(Y, 3) - 18;

    printf("\nY = %d\tX = %8.2f", Y, X);
}
