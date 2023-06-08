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
    printf("Ingresa los dos números: ");
    scanf("%d %d", &NU1, &NU2);
    RES = multiplo(NU1, NU2);
    if (RES)
        printf("El segundo número es múltiplo del primero\n");
    else
        printf("El segundo número no es múltiplo del primero\n");
    return 0;
}
