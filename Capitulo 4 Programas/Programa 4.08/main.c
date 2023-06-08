#include <stdio.h>

int a, b, c, d;

void funcion1(int*, int*);
int funcion2(int, int*);

int main(void) {
    a = 1;
    b = 2;
    c = 3;
    d = 4;
    printf("%d %d %d %d\n", a, b, c, d);
    funcion1(&b, &c);
    printf("%d %d %d %d\n", a, b, c, d);
    a = funcion2(c, &d);
    printf("%d %d %d %d\n", a, b, c, d);
    return 0;
}

void funcion1(int* b, int* c) {
    int d;
    a = 5;
    d = 3;
    (*b)++;
    (*c) += 2;
    printf("%d %d %d %d\n", a, *b, *c, d);
}

int funcion2(int c, int* d) {
    int b;
    a++;
    b = 7;
    c += 3;
    (*d) += 2;
    printf("%d %d %d %d\n", a, b, c, *d);
    return c;
}
