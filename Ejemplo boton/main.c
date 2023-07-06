#include <stdio.h>
#include <stdlib.h>

#define MONEDA_25   0
#define MONEDA_50   1
#define MONEDA_100  2
#define MONEDA_200  3
#define MONEDA_500  4

#define CANTIDAD    100

int main()
{
    printf("el que nacio pa etropajo nunca saldra del fregadero\n\n");

    int moneda[5];
    int moneda_siguiente= MONEDA_25;
    int moneda_actual=0;
    moneda[MONEDA_25]=25;
    moneda[MONEDA_50]=50;
    moneda[MONEDA_100]=100;
    moneda[MONEDA_200]=200;
    moneda[MONEDA_500]=500;

    do
    {
        if (moneda_siguiente==MONEDA_25)
        {
            moneda_actual==moneda[MONEDA_25];
        }
        if (moneda_siguiente==MONEDA_50)
        {
            moneda_actual==moneda[MONEDA_50];
        }
        if (moneda_siguiente==MONEDA_100)
        {
            moneda_actual==moneda[MONEDA_100];
        }
        if (moneda_siguiente==MONEDA_200)
        {
            moneda_actual==moneda[MONEDA_200];
        }
        if (moneda_siguiente==MONEDA_500)
        {
            moneda_actual==moneda[MONEDA_500];
        }

            for (int i=1; i<=100; i++)
            {
                printf("Se han impreso %d papeletas de %d.", i, moneda_actual);
            }
            printf("\n\n______________________________________________\n\n")


    }


}
