#include <stdio.h>
#include <stdbool.h>
#include <string.h>

typedef struct {
    char respuesta1[10];
    char respuesta2[10];
    char respuesta3[10];
    char respuesta4[10];
    char respuesta5[10];
} Respuestas;

bool esRespuestaValida(const char *respuesta) {
    return strcmp(respuesta, "si") == 0 || strcmp(respuesta, "no") == 0;
}

int main() {
    Respuestas respuestas;

    printf("¿Tienes fiebre en este momento? (si/no): ");
    scanf("%si", respuestas.respuesta1);

    printf("¿Experimentas tos persistente? (si/no): ");
    scanf("%s", respuestas.respuesta2);

    printf("¿Sientes dificultad para respirar o presión en el pecho? (si/no): ");
    scanf("%s", respuestas.respuesta3);

    printf("¿Estás experimentando fatiga extrema? (si/no): ");
    scanf("%s", respuestas.respuesta4);

    printf("¿Has estado en contacto con alguien positivo o viajado a áreas de riesgo recientemente? (si/no): ");
    scanf("%s", respuestas.respuesta5);

    if (esRespuestaValida(respuestas.respuesta1) && esRespuestaValida(respuestas.respuesta2) &&
        esRespuestaValida(respuestas.respuesta3) && esRespuestaValida(respuestas.respuesta4) &&
        esRespuestaValida(respuestas.respuesta5)) {

        char diagnostico[200];

        if (strcmp(respuestas.respuesta1, "si") == 0 || strcmp(respuestas.respuesta2, "si") == 0 ||
            strcmp(respuestas.respuesta3, "si") == 0 || strcmp(respuestas.respuesta4, "si") == 0 ||
            strcmp(respuestas.respuesta5, "si") == 0) {

            strcpy(diagnostico, "Podrías tener síntomas de COVID-19. Considera hacer una prueba y consultar a un médico.");
        } else {
            strcpy(diagnostico, "Tus síntomas son leves. Sigue las medidas de prevención y monitorea cualquier cambio.");
        }

        printf("Diagnóstico: %s\n", diagnostico);
    } else {
        printf("Ingresa respuestas válidas: 'si' o 'no'.\n");
    }

    return 0;
}
