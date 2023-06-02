#include <stdio.h>

int main(void) {
    int MAT, CAR, SEM;
    float PRO;

    printf("Ingrese matr�cula: ");
    scanf("%d", &MAT);

    printf("Ingrese carrera (1-Industrial 2-Telem�tica 3-Computaci�n 4-Mec�nica): ");
    scanf("%d", &CAR);

    printf("Ingrese semestre: ");
    scanf("%d", &SEM);

    printf("Ingrese promedio: ");
    scanf("%f", &PRO);

    switch (CAR) {
        case 1:
            if (SEM >= 6 && PRO >= 8.5)
                printf("%d %d %5.2f\n", MAT, CAR, PRO);
            break;
        case 2:
            if (SEM >= 5 && PRO >= 9.0)
                printf("%d %d %5.2f\n", MAT, CAR, PRO);
            break;
        case 3:
            if (SEM >= 6 && PRO >= 8.8)
                printf("%d %d %5.2f\n", MAT, CAR, PRO);
            break;
        case 4:
            if (SEM >= 7 && PRO >= 9.0)
                printf("%d %d %5.2f\n", MAT, CAR, PRO);
            break;
        default:
            printf("Error en la carrera\n");
            break;
    }

    return 0;
}
