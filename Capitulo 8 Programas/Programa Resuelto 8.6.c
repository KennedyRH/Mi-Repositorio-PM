#include <stdio.h>
#include <string.h>

typedef struct
{
    int clave;
    char nombre[15];
    float precio;
    int existencia;
} producto;

void Lectura(producto *, int);
void Ventas(producto *, int);
void Reabastecimiento(producto *, int);
void Nuevos_Productos(producto *, int *);
void Inventario(producto *, int);

void main(void)
{
    producto INV[100];
    int TAM, OPE;

    do
    {
        printf("Ingrese el numero de productos: ");
        scanf("%d", &TAM);
    } while (TAM > 100 || TAM < 1);

    Lectura(INV, TAM);

    printf("\nIngrese operacion a realizar.\n");
    printf("\t\t1 – Ventas\n");
    printf("\t\t2 – Reabastecimiento\n");
    printf("\t\t3 - Nuevos Productos\n");
    printf("\t\t4 – Inventario\n");
    printf("\t\t0 - Salir: ");
    scanf("%d", &OPE);

    while (OPE)
    {
        switch (OPE)
        {
        case 1:
            Ventas(INV, TAM);
            break;
        case 2:
            Reabastecimiento(INV, TAM);
            break;
        case 3:
            Nuevos_Productos(INV, &TAM);
            break;
        case 4:
            Inventario(INV, TAM);
            break;
        }

        printf("\nIngrese operacion a realizar.\n");
        printf("\t\t1 - Ventas\n");
        printf("\t\t2 - Reabastecimiento\n");
        printf("\t\t3 - Nuevos Productos\n");
        printf("\t\t4 - Inventario\n");
        printf("\t\t0 - Salir: ");
        scanf("%d", &OPE);
    }
}

void Lectura(producto A[], int T)
{
    int I;

    for (I = 0; I < T; I++)
    {
        printf("\nIngrese informacion del producto %d", I + 1);
        printf("\n\tClave: ");
        scanf("%d", &A[I].clave);
        fflush(stdin);
        printf("\tNombre:");
        gets(A[I].nombre);
        printf("\tPrecio:");
        scanf("%f", &A[I].precio);
        printf("\tExistencia: ");
        scanf("%d", &A[I].existencia);
    }
}

void Ventas(producto A[], int T)
{
    int CLA, CAN, I, RES;
    float TOT, PAR;

    printf("\nIngrese clave del producto -0 para salir-: ");
    scanf("%d", &CLA);

    TOT = 0.0;

    while (CLA)
    {
        printf("\tCantidad: ");
        scanf("%d", &CAN);

        I = 0;

        while ((I < T) && (A[I].clave < CLA))
            I++;

        if ((I == T) || (A[I].clave > CLA))
            printf("\nLa clave del producto es incorrecta");
        else if (A[I].existencia >= CAN)
        {
            A[I].existencia -= CAN;
            PAR = A[I].precio * CAN;
            TOT += PAR;
        }
        else
        {
            printf("\nNo existe en inventario la cantidad solicitada. Solo hay %d", A[I].existencia);
            printf("\nLos lleva 1 - Si 0 - No?: ");
            scanf("%d", &RES);

            if (RES)
            {
                PAR = A[I].precio * A[I].existencia;
                A[I].existencia = 0;
                TOT += PAR;
            }
        }

        printf("\nIngrese la siguiente clave del producto -0 para salir-: ");
        scanf("%d", &CLA);
    }

    printf("\nTotal de la venta: %f", TOT);
}

void Reabastecimiento(producto A[], int T)
{
    int CLA, CAN, I;

    printf("\nIngrese clave del producto -0 para salir-: ");
    scanf("%d", &CLA);

    while (CLA)
    {
        I = 0;

        while ((I < T) && (A[I].clave < CLA))
            I++;

        if ((I == T) || (A[I].clave > CLA))
            printf("\nLa clave del producto ingresada es incorrecta");
        else
        {
            printf("\tCantidad: ");
            scanf("%d", &CAN);
            A[I].existencia += CAN;
        }

        printf("\nIngrese otra clave del producto -0 para salir-: ");
        scanf("%d", &CLA);
    }
}

void Nuevos_Productos(producto A[], int *T)
{
    int CLA, I, J;

    printf("\nIngrese clave del producto -0 para salir-: ");
    scanf("%d", &CLA);

    while ((*T < 30) && (CLA))
    {
        I = 0;

        while ((I < *T) && (A[I].clave < CLA))
            I++;

        if (I == *T)
        {
            A[I].clave = CLA;
            printf("\tNombre:");
            fflush(stdin);
            gets(A[I].nombre);
            printf("\tPrecio:");
            scanf("%f", &A[I].precio);
            printf("\tCantidad: ");
            scanf("%d", &A[I].existencia);
            *T = *T + 1;
        }
        else if (A[I].clave == CLA)
            printf("\nEl producto ya se encuentra en el inventario");
        else
        {
            for (J = *T; J > I; J--)
                A[J] = A[J - 1];

            A[I].clave = CLA;
            printf("\tNombre:");
            fflush(stdin);
            gets(A[I].nombre);
            printf("\tPrecio:");
            scanf("%f", &A[I].precio);
            printf("\tCantidad: ");
            scanf("%d", &A[I].existencia);
            *T = *T + 1;
        }

        printf("\nIngrese otra clave de producto -0 para salir-: ");
        scanf("%d", &CLA);
    }

    if (*T == 30)
        printf("\nYa no hay espacio para incorporar nuevos productos");
}

void Inventario(producto A[], int T)
{
    int I;

    for (I = 0; I < T; I++)
    {
        printf("\nClave: %d", A[I].clave);
        printf("\tNombre: %s", A[I].nombre);
        printf("\tPrecio: %f", A[I].precio);
        printf("\tExistencia: %d \n", A[I].existencia);
    }
}