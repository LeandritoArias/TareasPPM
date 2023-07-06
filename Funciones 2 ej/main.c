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
double a[4];

int main()
{

    printf("EL QUE NACIO PA ETROPAJO NUNCA SALDRA DEL FREGADERO\n");

    int result=0;
    int num1=0, num2=0;


     a[PRE_CAL]=100;
     a[PROG1]=87.3;
     a[SYS_CONTROL]=85.5;
     a[CNC]=92;
     a[C2]=72.8;


      printf("\npromedio:\t%f",promedio());


/*    printf("\n\ndijite numero 1:\t");
    scanf("%d",&num1);
    printf("\ndijite numero 2:\t");
    scanf("%d",&num2);

    result= suma (num1,num2);
    printf("resultado de la suma de %d y %d:\t%d", num1, num2, result);
*/
    return 0;
}

int suma (int a, int b)
{
    int result= a+b;

    return result;
}

double promedio (void)

{
    double tmp=0.0;

    for (int i = 0;i<CANT_MAT;i++)
    {

        tmp+= a[i];
    }
    return tmp/CANT_MAT;
}
