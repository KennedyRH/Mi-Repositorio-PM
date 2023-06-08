#include <stdio.h>

int z, y;
int F1(float);
void F2(float, int*);

int main(void) {
    int w;
    float x;

    z = 5;
    y = 7;
    w = 2;
    x = (float)y / z;

    printf("Programa Principal: %d %d %.2f %d\n", z, y, x, w);

    F2(x, &w);

    printf("Programa Principal: %d %d %.2f %d\n", z, y, x, w);

    return 0;
}

int F1(float x) {
    int k;
    if (x != 0) {
        k = z - y;
        x++;
    } else {
        k = z + y;
    }
    printf("F1: %d %d %.2f %d\n", z, y, x, k);
    return k;
}

void F2(float t, int* r) {
    y = 5;
    z = 0;

    printf("F2: %d %d %.2f %d\n", z, y, t, *r);

    if (z == 0) {
        z = (*r) * 2;
        t = (float)z / 3;

        printf("Ingresa el valor: ");
        scanf("%d", r);

        printf("F2: %d %d %.2f %d\n", z, y, t, *r);
    } else {
        z = (*r) * 2;
        printf("F2: %d %d %.2f %d\n", z, y, t, *r);
    }

    *r = F1(t);
}
