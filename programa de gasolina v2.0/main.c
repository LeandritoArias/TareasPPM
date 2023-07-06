#include <stdio.h>
#include <stdlib.h>

/*
struct datos_cliente
{
    char nombre_cliente[50];
    int distancia[50];
    int combustible [50];
    int gastos_varios [50];
};
*/

int main()
{
    printf("DISTRIBUIDOR EXCLUSIVO LEPROCOMIO EDUARDO BRITO\n\n");

    char nombre_cliente[50];
    int distancia[50];
    int combustible [50];
    int gastos_varios [50];



    FILE *ar;

    if ((ar=fopen("arc.txt","w"))!=NULL)
    {
        printf("\n------------------------------------ \n");
        printf("\nregistro de la wea esa del carro ese \n");
        printf("\n------------------------------------ \n\n");

        fputs("\n------------------------------------------------------------\n", ar);
        fflush(stdin);
        fputs("Cliente||\tDistancia|\eficiencia.\tComb.(galon)|\tGastos varios|\t",ar);
        fflush(stdin);
        fputs("\n------------------------------------------------------------\n", ar);
        fflush(stdin);


        for (int i=0; i<1; i++)

        {
            fflush(stdin);
            printf("Ingrese el nombre del cliente:\t");
            gets(nombre_cliente);
            fputs(nombre_cliente, ar);
            fputs("\t||\t", ar);

            fflush(stdin);
            printf("Ingrese la distancia recorrida(km):\t");
            gets(distancia);
            fputs(distancia, ar);
            fputs("\t|\t", ar);

            fflush(stdin);
            printf("Ingrese la eficiencia prom. del vehiculo (L/100km):\t");
            gets(distancia);
            fputs(distancia, ar);
            fputs("\t|\t", ar);

            fflush(stdin);
            printf("Ingrese cantidad de combustible que gasta(En pesos, $300/G):\t");
            gets(combustible);
            fputs(combustible, ar);
            fputs("\t|\t", ar);

            fflush(stdin);
            printf("Ingrese gastos varios(en pesos):\t");
            gets(gastos_varios);
            fputs(gastos_varios, ar);
            fputs("\t|\t", ar);

            fflush(stdin);

            printf("\n\nsiguiente cliente:\n\n");
            fputs("\\n\n------------------------------------------------------------\n", ar);

        }
        fclose(ar);

        FILE *ar= fopen("arc.txt","r");

        char linea;

        while (feof(ar)==0)
        {
            linea=fgetc(linea);
            printf("%s", linea);
        }

        fclose(ar);
    }
    else
        printf("no se puede abrir el archivo");
    return 0;
}



