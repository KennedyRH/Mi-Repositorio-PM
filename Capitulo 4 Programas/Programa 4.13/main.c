#include <stdio.h>
#include <math.h>

void parimp(int NUM, int *P, int *I) {
    int RES = pow(-1, NUM);
    if (RES > 0)
        (*P)++;
    else if (RES < 0)
        (*I)++;
}

int main(void) {
    int I, N, NUM, PAR = 0, IMP = 0;
    printf("Ingresa el número de datos: ");
    scanf("%d", &N);

    for (I = 1; I <= N; I++) {
        printf("Ingresa el número %d: ", I);
        scanf("%d", &NUM);
        parimp(NUM, &PAR, &IMP);
    }

    printf("\nNúmero de pares: %d", PAR);
    printf("\nNúmero de impares: %d", IMP);

    return 0;
}
