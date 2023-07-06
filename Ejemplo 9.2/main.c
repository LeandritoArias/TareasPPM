#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("DISTRIBUIDOR EXCLUSIVO LEPROCOMIO EDUARDO BRITO\n\n\n");

    char p1;

    FILE *ar;
    if ((ar = fopen("vicio.txt", "r"))!=NULL)
    {
        while (!feof(ar))
        {

        p1= fgetc(ar);
        putchar(p1);
        }
        fclose(ar);

    }
    else

        printf("\n\nCompai revise a ver klk ute me ta pidiendo");

    return 0;
}
