#include <stdio.h>

void Mayor(float R1, float R2, float R3);

void main(void) {
    int I;
    float GOL, PAC, CAR;
    float AGOL = 0, APAC = 0, ACAR = 0;

    for (I = 1; I <= 12; I++) {
        printf("\n\nIngresa las lluvias del mes %d", I);
        printf("\nRegiones Golfo, Pacífico y Caribe: ");
        scanf("%f %f %f", &GOL, &PAC, &CAR);
        AGOL += GOL;
        APAC += PAC;
        ACAR += CAR;
    }

    printf("\n\nPromedio de lluvias Región Golfo: %6.2f", (AGOL / 12));
    printf("\nPromedio de lluvias Región Pacífico: %6.2f", (APAC / 12));
    printf("\nPromedio de lluvias Región Caribe: %6.2f \n", (ACAR / 12));

    Mayor(AGOL, APAC, ACAR);
}

void Mayor(float R1, float R2, float R3) {
    if (R1 > R2) {
        if (R1 > R3)
            printf("\nRegión con mayor promedio: Región Golfo. Promedio: %6.2f", R1 / 12);
        else
            printf("\nRegión con mayor promedio: Región Caribe. Promedio: %6.2f", R3 / 12);
    } else {
        if (R2 > R3)
            printf("\nRegión con mayor promedio: Región Pacífico. Promedio: %6.2f", R2 / 12);
        else
            printf("\nRegión con mayor promedio: Región Caribe. Promedio: %6.2f", R3 / 12);
    }
}
