#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("EL QUE NACIO PA ETROPAJO NUNCA SALDRA DEL FREGADERO\n");

    int A=100, B=5, C=0;


    int *ptrA=&A;
    ptrA=5;


    int *ptrB=&B;
    ptrB=2;

    printf("\nvalor de direccion de A: %p", &A);
    printf("\nvalor de direccion de ptrA: %p", ptrA);
    printf("\nvalor de direccion de b: %p", ptrB);


    return 0;
}
