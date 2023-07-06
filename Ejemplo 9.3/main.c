#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("DISTRIBUIDOR EXCLUSIVO LEPROCOMIO EDUARDO BRITO\n\n");

    int res;
    char cad[50];
    FILE *ar;

    if ((ar=fopen("arc.txt","w"))!=NULL)
    {
        printf("\n\ndesea ingresar una cadena de caracteres?    si-1    no-0\n");
        scanf("%d", &res);

        while(res)

        {
            fflush(stdin);
            printf("Ingrese la cadena:\t");
            gets(cad);
            fputs(cad, ar);

            printf("\nDesea ingresar otra cadena?    si-1    no-0");
            scanf("%d", &res);

            if (res)
            fputc("\n",ar);

        }
        fclose(ar);
    }
    else
        printf("no se puede abrir el archivo");

    return 0;
}
