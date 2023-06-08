#include <stdio.h>

int mad(int N1) {
    int I = N1 / 2;
    while (N1 % I != 0)
        I--;
    return I;
}

int main(void) {
    int NUM, RES;
    printf("Ingresa el número: ");
    scanf("%d", &NUM);
    RES = mad(NUM);
    printf("El mayor divisor de %d es: %d\n", NUM, RES);
    return 0;
}
