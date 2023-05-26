#include <stdio.h>

/* Estancia
El programa, al recibir como dato la superficie de una estancia expresada
en acres, la convierte a hect�reas.
ECA: variable de tipo real. */

void main(void) {
    float ECA;

    printf("Ingrese la extensi�n de la estancia: ");
    scanf("%f", &ECA);

    ECA = ECA * 4047 / 10000;

    printf("\nExtensi�n de la estancia en hect�reas: %5.2f", ECA);

    return 0;
}
