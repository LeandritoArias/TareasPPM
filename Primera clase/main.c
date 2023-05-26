#include <stdio.h>
#include <stdlib.h>

int main()
{
    char nombre[20];
    char apellido[20];
    unsigned int edad;
    char a;

    int menu=1;

    while(menu)
    {
    printf("\nEscriba su nombre:  ");
    scanf("%s", nombre);
    printf("\nEscriba su apellido:  ");
    scanf("%s", apellido);
    printf("\nEscriba su edad:  ");
    scanf("%d", &edad);

     printf("\n\n\n");
    if (edad>=16 && edad<80)
    {
        printf("Hola %s %s, DELE PA DENTRO",nombre, apellido);
    }

    else if (edad>=80)
    {
        printf("Hola %s %s, MIRE JABLADORASO",nombre, apellido);
    }
    else if (edad<16)
    {
        printf("Hola %s %s, RUEDE DURISIMO",nombre, apellido);

    }

        printf("\n\n\n VA SEGUI?     1- SEGUIR  0- RODAR  ");
        scanf("%d",&menu);

    }
    printf("\n\n\n");
    return 10;
}
