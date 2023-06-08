#include <stdio.h>

int F1(int, int*);

int A = 3;
int B = 7;
int C = 4;
int D = 2;

int main() {
    A = F1(C, &D);
    printf("%d %d %d %d\n", A, B, C, D);

    C = 3;
    C = F1(A, &C);
    printf("%d %d %d %d\n", A, B, C, D);

    return 0;
}

int F1(int X, int* Y) {
    int A;
    A = X * (*Y);
    C++;
    B += (*Y);
    printf("%d %d %d %d\n", A, B, C, D);
    (*Y)--;
    return C;
}
