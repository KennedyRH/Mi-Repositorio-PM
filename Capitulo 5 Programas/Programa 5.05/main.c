#include <stdio.h>

const int TAM = 50;

void Lectura(int VEC[], int T);
void Frecuencia(int A[], int P, int B[], int T);
void Impresion(int VEC[], int T);
void Mayor(int X[], int T);

int main(void) {
    int CAL[TAM], FRE[6] = {0};

    Lectura(CAL, TAM);
    Frecuencia(CAL, TAM, FRE, 6);

    printf("\nFrecuencia de Calificaciones\n");
    Impresion(FRE, 6);
    Mayor(FRE, 6);

    return 0;
}

void Lectura(int VEC[], int T) {
    int I;
    for (I = 0; I < T; I++) {
        printf("Ingrese la calificaci�n (0-5) del alumno %d: ", I + 1);
        scanf("%d", &VEC[I]);
    }
}

void Impresion(int VEC[], int T) {
    int I;
    for (I = 0; I < T; I++) {
        printf("\nVEC[%d]: %d", I, VEC[I]);
    }
}

void Frecuencia(int A[], int P, int B[], int T) {
    int I;
    for (I = 0; I < P; I++) {
        if ((A[I] >= 0) && (A[I] < 6)) {
            B[A[I]]++;
        }
    }
}

void Mayor(int X[], int T) {
    int I, MFRE = 0, MVAL = X[0];
    for (I = 1; I < T; I++) {
        if (MVAL < X[I]) {
            MFRE = I;
            MVAL = X[I];
        }
    }
    printf("\n\nMayor frecuencia de calificaciones: %d \tValor: %d", MFRE, MVAL);
}
