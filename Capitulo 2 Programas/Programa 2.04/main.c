#include <stdio.h>

int main(void) {
    float PRE, NPR;
    printf("Ingrese el precio del producto: ");
    scanf("%f", &PRE);

    if (PRE < 1500)
        NPR = PRE * 1.11;
    else
        NPR = PRE * 1.08;

    printf("\nNuevo precio del producto: %8.2f", NPR);

    return 0;
}
