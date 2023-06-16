#include <stdio.h>
#include <string.h>

void intercambia(char FRA[][30], int);

int main(void) {
    int i, n;
    char FRA[20][30];

    printf("\nIngrese el número de filas del arreglo: ");
    scanf("%d", &n);

    for (i = 0; i < n; i++) {
        printf("Ingrese la línea de texto número %d: ", i + 1);
        fflush(stdin);
        fgets(FRA[i], sizeof(FRA[i]), stdin);

        // Eliminar el salto de línea al final de la cadena
        FRA[i][strlen(FRA[i]) - 1] = '\0';
    }

    printf("\n\n");

    intercambia(FRA, n);

    for (i = 0; i < n; i++) {
        printf("Impresión de la línea de texto %d: %s\n", i + 1, FRA[i]);
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
