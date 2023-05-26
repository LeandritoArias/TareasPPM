#include <stdio.h>
#include <stdlib.h>


//Aplicacion de operadores

int main()
{

        int i=5;
        int j=7;
        int k=3;
        int m1;

        float x=2.5;
        float z=1.8;
        float t;

        m1= ((j%k)/2) +1;
        m1 += i;
        m1 %= --i;
        printf("\n El valor de m1 es: %d", m1);

        t= ((float)(j%k)/2);
        t++;
        x *= ++z;
        t -= (x += ++i);
        printf("\n El valor de t es: %.3f", t);

}
