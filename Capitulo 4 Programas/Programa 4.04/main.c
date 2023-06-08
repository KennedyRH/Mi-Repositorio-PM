#include <stdio.h>

void f1();
void f2();
void f3();
void f4();

int K = 5;

int main(void) {
    int I;
    for (I = 1; I <= 3; I++) {
        printf("\nEl resultado de la función f1 es: ");
        f1();
        printf("\nEl resultado de la función f2 es: ");
        f2();
        printf("\nEl resultado de la función f3 es: ");
        f3();
        printf("\nEl resultado de la función f4 es: ");
        f4();
    }
    return 0;
}

void f1() {
    K += K;
    printf("%d", K);
}

void f2() {
    int K = 2;
    K++;
    printf("%d", K);
}

void f3() {
    static int K = 8;
    K += 2;
    printf("%d", K);
}

void f4() {
    int K = 5;
    K = K + K;
    printf("%d", K);
}
