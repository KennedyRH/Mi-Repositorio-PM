#include <stdio.h>

int main(void) {
    float SAL;
    int NIV;

    printf("Ingrese el nivel acad�mico del profesor: ");
    scanf("%d", &NIV);

    printf("Ingrese el salario: ");
    scanf("%f", &SAL);

    switch (NIV) {
        case 1:
            SAL = SAL * 1.0035;
            break;
        case 2:
            SAL = SAL * 1.0041;
            break;
        case 3:
            SAL = SAL * 1.0048;
            break;
        case 4:
            SAL = SAL * 1.0053;
            break;
    }

    printf("\n\nNivel: %d \tNuevo salario: %8.2f", NIV, SAL);

    return 0;
}
