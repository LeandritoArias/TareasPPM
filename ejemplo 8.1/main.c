#include <stdio.h>
#include <stdlib.h>
#include <string.h>

//Este programa es para aprender a usar las estructuras, y a acceder a los campos
//de variables de tipo lectura y asignacion de variables tipo lectura y escritura.

    struct alumno       //delcaracion de estructura
    {
      int matricula;
      char nombre [20];
      char carrera [20];        //campos de la estructura
      float promedio;
      char direccion[200];

    };   ///waos descrubri algo nuevo hoy :v aqui se pone punto y coma y ni idea de por que pero se pone



int main()
{
    printf("Todo el mundo tiene un plan hasta que le pegas un guamaso en el pecueso\n");

    // obsera que las variables de tipo estructura se declaran como cualquier otra variable

    // las variables a1, a2 y a3 son de tipo 'alumno estructura'

    struct alumno a1 = {120, "eleuterio", "filosofia", 9.1, "Gualei"},a2, a3;

        //aqui el campo a1 reciben los valores directamente, los otros dos lo recibiran luego.

        char nombre1[20], carrera1[20], direccion1[200];
        int matricula1;
        float promedio1;

        //diferencia entre recibir valores por medio de lectura y por medio de asignaciones

        // aqui se recibiran los valores de a2 por medio de lectura

        printf("\nIngrese la matricula del alumno 2:\t");
        scanf("%d",&a2.matricula);
        fflush(stdin);
        printf("\nIngrese el nombre del alumno 2:\t");
        gets(a2.nombre);
        printf("\nIngrese la carrera del alumno 2:\t");
        gets(a2.carrera);
        printf("\nIngrese el promedio del alumno 2:\t");
        scanf("%f",&a2.promedio);
        fflush(stdin);
        printf("\nIngrese direccion del alumno 2:\t");
        gets(a2.direccion);

        // aqui se reciben los valores de a3 por medio de asignaciones

        printf("\nIngrese la matricula del alumno 3:\t");
        scanf("%d",&matricula1);
        a3.matricula= matricula1;
        fflush(stdin);
        printf("\nIngrese el nombre del alumno 3:\t");
        gets(nombre1);
        strcpy(a3.nombre, nombre1);
        printf("\nIngrese la carrera del alumno 3:\t");
        gets(carrera1);
        strcpy(a3.carrera, carrera1);
        printf("\nIngrese el promedio del alumno 3:\t");
        scanf("%f",promedio1);
        fflush(stdin);
        printf("\nIngrese direccion del alumno 3:\t");
        gets(direccion1);
        strcpy(a3.direccion, direccion1);

        //aqui se imprimiran los valores de a2 y a3

        printf("\n\nDatos del alumno:\n---------------------------------\n");
        printf("%d\n", a1.matricula);
        puts(a1.nombre);
        puts(a1.carrera);
        printf("%.2f\n",a1.promedio);
        puts(a1.direccion);

        printf("%d\n", a2.matricula);
        puts(a2.nombre);
        puts(a2.carrera);
        printf("%.2f\n",a2.promedio);
        puts(a2.direccion);

        printf("%d\n", a3.matricula);
        puts(a3.nombre);
        puts(a3.carrera);
        printf("%.2f\n",a3.promedio);
        puts(a3.direccion);



    return 0;
}
