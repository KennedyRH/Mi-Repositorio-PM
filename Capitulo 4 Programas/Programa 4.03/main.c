#include <stdio.h>

void f1();
int K = 5;

void main(void) {
    int I;
    for (I = 1; I <= 3; I++)
        f1();
}

void f1() {
    int K = 2;

    K += K;

    printf("\n\nEl valor de la variable local es: %d", K);

    K = K + K;

    printf("\nEl valor de la variable global es: %d", K);
}
