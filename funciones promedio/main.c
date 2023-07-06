#include <stdio.h>
#include <stdlib.h>

#define PRE_CAL         0
#define PROG1           1
#define SYS_CONTROL     2
#define CNC             3
#define C2              4

#define CANT_MAT        5

int suma (int a, int b);
double promedio (void);

int main()
{

    printf("EL QUE NACIO PA ETROPAJO NUNCA SALDRA DEL FREGADERO\n");

    int result=0;
    int num1=0, num2=0;
    double a[4];

    double *ptr_a=a;


     a[PRE_CAL]=100;
     a[PROG1]=87.3;
     a[SYS_CONTROL]=85.5;
     a[CNC]=92;
     a[C2]=72.8;


      printf("\npromedio:\t%f",promedio());

    return 0;
}

int     suma (int *a, int *b)
{
    int result= a+b;

    return result;
}

double promedio (void)

{
    double tmp=0.0;

    return tmp/CANT_MAT;
}
