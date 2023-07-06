#include <stdio.h>
#include <stdlib.h>

#define columnas 3
#define filas 3

void recibir(int A[columnas][filas], int f);
void suma ();
void multiplicacion();
void respuesta();

int main ()
{
    int matriz [columnas][filas];
    recibir;

}

void recibir (int A[columnas][filas], int f)
{
    int i,j;

    for (i=0;i<j;i++)
        for(j=0;j<f;j++)
    {
        printf("Ingrese el elemento [%d][%d]:\t", i+1, j+1);
        scanf("%d", &A[i][j]);
    }

}
