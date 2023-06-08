#include <stdio.h>

int cubo(int);

void main(void) {
    int I;
    for (I = 1; I <= 10; I++)
        printf("\nEl cubo de %d es: %d", I, cubo(I));
}

int cubo(int K) {
    return K * K * K;
}
