#include <stdio.h>

int main(void) {
    float PRO;
    printf("Ingrese el promedio del alumno: ");
    scanf("%f", &PRO);

    if (PRO >= 6)
        printf("\nAprobado");

    return 0;
}
