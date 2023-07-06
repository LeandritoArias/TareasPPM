#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("DISTRIBUIDOR EXCLUSIVO LEPROCOMIO EDUARDO BRITO\n\n");

    char  p1;
    FILE *ar;
    ar = fopen("vicio.txt", "w");

    if (ar != NULL)
        {
                printf("Ecribe lo que se te de la regalada gana pa que\nguarde una vaina ahi bien bacanal:\t\t");

        while ((p1=getchar()) !=  '\n')

            fputc(p1, ar);
            fclose(ar);
        }
    else
    printf("No se puede abrir el archivo");

    return 0;
}
