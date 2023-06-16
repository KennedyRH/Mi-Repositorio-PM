#include <stdio.h>
#include <string.h>

int longitud(char *);

int main(void) {
    int i, n, l = -1, p, t;
    char cad[50], FRA[20][50];

    printf("\nIngrese el número de filas del arreglo: ");
    scanf("%d", &n);

    for (i = 0; i < n; i++) {
        printf("Ingrese la línea %d de texto. Máximo 50 caracteres: ", i + 1);
        fflush(stdin);
        fgets(FRA[i], sizeof(FRA[i]), stdin);

        FRA[i][strlen(FRA[i]) - 1] = '\0';
    }

    printf("\n");

    for (i = 0; i < n; i++) {
        strcpy(cad, FRA[i]);
        t = longitud(cad);

        if (t > l) {
            l = t;
            p = i;
        }
    }

    printf("\nLa cadena con mayor longitud es: %s\n", FRA[p]);
    printf("Longitud: %d\n", l);

    return 0;
}

int longitud(char *cadena) {
    int cue = 0;

    while (cadena[cue] != '\0')
        cue++;

    return cue;
}
