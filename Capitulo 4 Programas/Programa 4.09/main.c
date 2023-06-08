#include <stdio.h>

int Suma(int X, int Y) {
    return X + Y;
}

int Resta(int X, int Y) {
    return X - Y;
}

int Control(int (*apf)(int, int), int X, int Y) {
    int RES;
    RES = (*apf)(X, Y);
    return RES;
}

int main(void) {
    int R1, R2;
    R1 = Control(Suma, 15, 5);
    R2 = Control(Resta, 10, 4);
    printf("Resultado 1: %d\n", R1);
    printf("Resultado 2: %d\n", R2);
    return 0;
}
