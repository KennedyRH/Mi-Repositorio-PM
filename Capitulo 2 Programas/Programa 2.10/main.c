#include <stdio.h>
#include <math.h>

int main(void) {
    int NUM;

    printf("Ingrese el número: ");
    scanf("%d", &NUM);

    if (NUM == 0)
        printf("\nNulo");
    else if (pow(-1, NUM) > 0)
        printf("\nPar");
    else
        printf("\nImpar");

    return 0;
}
