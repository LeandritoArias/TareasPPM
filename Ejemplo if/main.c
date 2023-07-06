#include <stdio.h>
#include <stdlib.h>

//programa que calcula un descuento del 11% si viene superada una compra
// de 1,500 pesos.

int main()
{
    printf("El que nacio pa etropajo nunca saldra del fregadero\n");

    float precio_entrada=0.0;
    float precio_final=0.0;

    printf("Ingrese el precio de entrada:\t ");
    scanf("%f", &precio_entrada);

    if (precio_entrada>1500)

    {

        precio_final= (precio_entrada*1.11);
        printf("\n El precio final sera: %7.2f.\n Se le suma el 11 porciento por sobrepasar los 1500 pesos.", precio_final);

    }

    else if(precio_entrada<=1500 && precio_entrada>=0)

    {
        precio_final= precio_entrada-(precio_entrada*0.11);
        printf("\n El precio final sera: %7.2f.\n Se aplica un dies por ciento de descuento por ser menor de 1500 pesos.", precio_final);


    }
    else
    {
        printf("\n El precio no es valido.");
    }



return 0;
}
