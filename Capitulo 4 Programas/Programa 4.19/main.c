#include <stdio.h>

int a, b, c, d; // Variables globales

void funcion1(int r, int* b, int* c); // Prototipo de función
int funcion2(int* d, int c);

int main() {
    a = 1;
    b = 2;
    c = 3;
    d = 4;

    printf("%d %d %d %d\n", a, b, c, d);

    a = funcion2(&a, c);

    printf("%d %d %d %d\n", a, b, c, d);

    return 0;
}

void funcion1(int r, int* b, int* c) {
    int d;
    int a = *c;

    d = a + 3 + *b;

    if (r) {
        *b = *b + 2;
        *c = *c + 3;
        printf("%d %d %d %d\n", a, *b, *c, d);
    } else {
        *b = *b + 5;
        *c = *c + 4;
        printf("%d %d %d %d\n", a, *b, *c, d);
    }
}

int funcion2(int* d, int c) {
    int b;
    int a = 1;

    b = 7;

    funcion1(-1, d, &b);

    printf("%d %d %d %d\n", a, b, c, *d);

    c += 3;
    (*d) += 2;

    printf("%d %d %d %d\n", a, b, c, *d);

    return c;
}
