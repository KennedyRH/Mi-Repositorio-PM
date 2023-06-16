#include <stdio.h>
#include <string.h>

void intercambia(char FRA[][30], int);

int main(void) {
    int i, n;
    char FRA[20][30];

    printf("\nIngrese el n�mero de filas del arreglo: ");
    scanf("%d", &n);

    for (i = 0; i < n; i++) {
        printf("Ingrese la l�nea de texto n�mero %d: ", i + 1);
        fflush(stdin);
        fgets(FRA[i], sizeof(FRA[i]), stdin);

        // Eliminar el salto de l�nea al final de la cadena
        FRA[i][strlen(FRA[i]) - 1] = '\0';
    }

    printf("\n\n");

    intercambia(FRA, n);

    for (i = 0; i < n; i++) {
        printf("Impresi�n de la l�nea de texto %d: %s\n", i + 1, FRA[i]);
    }

    return 0;
}

void intercambia(char FRA[][30], int n) {
    int i, j;
    char cad[30];

    j = n - 1;

    for (i = 0; i < (n / 2); i++) {
        strcpy(cad, FRA[i]);
        strcpy(FRA[i], FRA[j]);
        strcpy(FRA[j], cad);
        j--;
    }
}
