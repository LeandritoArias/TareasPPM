#include <stdio.h>
#include <stdlib.h>

int main()
{
   float f1=0.0;
   double d1=0.0;
   int i1=0;

   char c= 'a';
   char ar[50];
   int array [50];

   printf("\ndimension de f1: %d",sizeof (f1));
   printf("\ndimension de d1: %d",sizeof (d1));
   printf("\ndimension de i1: %d",sizeof (i1));
   printf("\ndimension de c: %d",sizeof (c));
   printf("\ndimension de ar: %d",sizeof (ar));
   printf("\ndimension de array: %d",sizeof (array));


   printf("\ndimension de f1: %d",&f1);
   printf("\ndimension de d1: %d",&d1);
   printf("\ndimension de i1: %d",&i1);
   printf("\ndimension de c: %d",&c);
   printf("\ndimension de ar: %d",&ar);
   printf("\ndimension de array: %d",&array);
}
