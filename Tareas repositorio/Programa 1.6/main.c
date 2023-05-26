#include <stdio.h>
#include <stdlib.h>

int main()
{
int i,j,k,l;

    printf("valor de i: ");
    scanf("%d", i);


    j= (15> i--) > (14 < i++);
    printf("\n El valor de j es: %d.", j);

    k= ('b'!= 'd') > (!i -1);
    printf("\n El valor de k es: %d.", k);

    l= (!(34>(70%2))||0);
    printf("\n El valor de l es: %d.", l);

}
