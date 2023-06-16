#include <stdio.h>
#include <string.h>

int contarPalabras(char *);

int main(void) {
    char frase[50];

    printf("\nIngrese la línea de texto: ");
    gets(frase);

    int cantidadPalabras = contarPalabras(frase);
    printf("\nLa línea de texto tiene %d palabras", cantidadPalabras);

    return 0;
}

int contarPalabras(char *cadena) {
    int contador = 0;
    int longitud = strlen(cadena);
    int i;

    while (isspace(cadena[0])) {
        cadena++;
        longitud--;
    }

    for (i = 0; i < longitud; i++) {
        if (isspace(cadena[i])) {

            while (isspace(cadena[i]))
                i++;

            contador++;
        }
    }

    return contador;
}
