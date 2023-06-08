#include <stdio.h>

int mcd(int N1, int N2) {
    int I;
    if (N1 < N2)
        I = N1 / 2;
    else
        I = N2 / 2;

    while (N1 % I != 0 || N2 % I != 0)
        I--;

    return I;
}

int main(void) {
    int NU1, NU2, RES;
    printf("Ingresa los dos números enteros: ");
    scanf("%d %d", &NU1, &NU2);
    RES = mcd(NU1, NU2);
    printf("El máximo común divisor de %d y %d es: %d\n", NU1, NU2, RES);
    return 0;
}
