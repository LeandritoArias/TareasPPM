#include <stdio.h>
#include <stdlib.h>

int main()
{
   double x=0;
   double b=0;

   printf("\nde un valor de x:  ");
   scanf("%lf", &x);
   b=x;

   while (!(b==(x/b)))
   {
       b= ((x/b)+b)/2;
   }

  printf("\n\nla raiz cuadrada de %d es igual a %lf", &x, &b);

    return 0;+
}
