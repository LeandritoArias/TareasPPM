#include <stdio.h>
#include <stdlib.h>


//calculo de impuestos sobre nomina

int main()
{
    printf("El que nacio pa etropajo nunca saldra del fregadero\n");

    float sueldo=0.0;
    float impuesto=0.0;

    printf("Ingrese su sueldo:\t ");
    scanf("%f", &sueldo);


    if (sueldo>100000)

    {

        impuesto= (sueldo*1.11);
        printf("\n El impuesto a pagar es:\t%7.5fTu sueldo es mayor que 10000", sueldo*0.25);

    }

    else
    {
        if(sueldo>0.0)
        {
            if(sueldo>50000)
            {
                printf("\n El impuesto a pagar es:\t%7.5f\n Tu sueldo es mayor que 50000.", sueldo*0.10);
            }
            else if (sueldo>25000)
            {
                printf("\n El impuesto a pagar es:\t%7.5f\nTu sueldo es mayor que 25000.", sueldo*0.5);
            }
            else
            {
                printf("\n El impuesto a pagar es:\t%7.5f\nTu sueldo es menor que 25000", sueldo*0.2);
            }
        }
        else
        {
             printf("\n AMIGO TRABAJE");
        }
    }



return 0;
}
