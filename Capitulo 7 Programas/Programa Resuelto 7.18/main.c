#include <stdio.h>

void inverso(char *);

void main(void) {
    char fra[50];

    printf("\nIngrese la l�nea de texto: ");
    gets(fra);

    printf("\nEscribe la l�nea de texto en forma inversa: ");
    inverso(fra);
    putchar('\n');
}

void inverso(char *cadena) {
    if (cadena[0] != '\0') {
        inverso(&cadena[1]);
        putchar(cadena[0]);
    }
}
