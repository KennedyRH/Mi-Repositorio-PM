#include <stdio.h>

int main(void) {
    int I, NUM, CUE = 0;
    int ARRE[100];

    for (I = 0; I < 100; I++) {
        printf("Ingrese el elemento %d del arreglo: ", I + 1);
        scanf("%d", &ARRE[I]);
    }

    printf("\nIngrese el n�mero que se va a buscar en el arreglo: ");
    scanf("%d", &NUM);

    for (I = 0; I < 100; I++) {
        if (ARRE[I] == NUM) {
            CUE++;
        }
    }

    printf("\nEl %d se encuentra %d veces en el arreglo.\n", NUM, CUE);

    return 0;
}
