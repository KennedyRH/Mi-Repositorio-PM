#include <stdio.h>
/* Medidas.
El programa, al recibir como datos la longitud y el peso de un objeto
expresados en pies y libras, calcula los datos de este objeto pero en
metros y kilogramos, respectivamente.
PIE, LIB, MET y KIL: variables de tipo real. */

int main(void) {
    float PIE, LIB, MET, KIL;

    printf("Ingrese los datos del objeto: ");
    scanf("%f %f", &PIE, &LIB);

    MET = PIE * 0.09290;
    KIL = LIB * 0.45359;

    printf("\nDatos del objeto:\nLongitud: %.2f metros\tPeso: %.2f kilogramos", MET, KIL);

    return 0;
}
