#include <stdio.h>
#include <math.h>


/* Volumen y �rea del cilindro
El programa, al recibir como datos el radio y la altura de un cilindro,
calcula su �rea y su volumen.
RAD, ALT, VOL y ARE: variables de tipo real. */


int main(void) {

    float RAD, ALT, VOL, ARE;

    printf("Ingrese el radio y la altura del cilindro: ");

    scanf("%f %f", &RAD, &ALT);

    VOL = M_PI * pow(RAD, 2) * ALT;

    ARE = 2 * M_PI * RAD * (RAD + ALT);

    printf("\nEl volumen es: %6.2f \t El �rea es: %6.2f", VOL, ARE);

    return 0;
}
