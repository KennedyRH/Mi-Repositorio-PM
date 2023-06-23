#include <stdio.h>
#include <ctype.h>

void minymay(FILE *);

void main(void) {
    FILE *ap;

    if ((ap = fopen("arc.txt", "r")) != NULL) {
        minymay(ap);
        fclose(ap);
    } else {
        printf("No se puede abrir el archivo");
    }
}

void minymay(FILE *ap1) {
    char cad[30];
    int i, mi = 0, ma = 0;

    while (!feof(ap1)) {
        fgets(cad, 30, ap1);

        i = 0;
        while (cad[i] != '\0') {
            if (islower(cad[i]))
                mi++;
            else if (isupper(cad[i]))
                ma++;

            i++;
        }
    }

    printf("\n\nN�mero de letras min�sculas: %d", mi);
    printf("\nN�mero de letras may�sculas: %d", ma);
}
