#include <stdio.h>

int multiplo(int N1, int N2) {
    int RES;
    if ((N2 % N1) == 0)
        RES = 1;
    else
        RES = 0;
    return RES;
}

int main(void) {
    int NU1, NU2, RES;
    printf("Ingresa los dos n�meros: ");
    scanf("%d %d", &NU1, &NU2);
    RES = multiplo(NU1, NU2);
    if (RES)
        printf("El segundo n�mero es m�ltiplo del primero\n");
    else
        printf("El segundo n�mero no es m�ltiplo del primero\n");
    return 0;
}
