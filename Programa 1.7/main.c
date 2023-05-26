#include <stdio.h>
#include <stdlib.h>

//Medidas
// El programa calcula la longitud y peso de un objeto
// convirtiendo de pies a metros y de libras a kilogramos.

int main()
{
        float PIE, LIB, MET, KIL;

        printf("Ingrese los datos del objeto: ");
        scanf("%f  %f", &PIE, &LIB);

        MET = PIE*0.3048;  // la medida de conversion de longitud en el libro estaba mal
        KIL = LIB*0.45359;
        printf("\nDatos del objeto \nLongitud: %5.2f  \t Peso: %5.2f", MET, KIL);

}
