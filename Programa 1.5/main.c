#include <stdio.h>

/* Aplicaci�n de operadores. */

void main(void) {
    int i = 5, j = 7, k = 3, m1;
    float x = 2.5, z = 1.8, t;

    m1 = ((j % k) / 2) + 1;
    m1 += i;
    m1 %= --i;

    printf("\nEl valor de m1 es: %d", m1);

    t = ((float)(j % k) / 2);
    t++;
    x *= ++z;
    t -= (x += ++i);

    printf("\nEl valor de t es: %.2f", t);

    return 0;
}
