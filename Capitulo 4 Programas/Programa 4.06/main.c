#include <stdio.h>

void f1(int *);

int main(void) {
    int I, K = 5;
    for (I = 1; I <= 3; I++) {
        printf("\n\nValor de K antes de llamar a la funci�n: %d", K);
        f1(&K);
        printf("\nValor de K despu�s de llamar a la funci�n: %d", K);
        K += I;
    }
    return 0;
}

void f1(int *R) {
    *R += *R;
}
