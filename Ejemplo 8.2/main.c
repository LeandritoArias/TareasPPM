#include <stdio.h>
#include <stdlib.h>
#include <string.h>

    // el mismo programa que antes solo que en este se usa punteros

    struct alumno
    {
        int matricula;
        char nombre [20];
        char carrera [20];
        float promedio;
        char direccion [20];
    };

void Lectura(struct alumno*);



void main()
{
    printf("Todo el mundo tiene un plan hasta que le pegas un guamaso en el pecueso\n");

    struct alumno a0= {120, "Mauricio", "Nutricion", 8.8, "Villa Juana"};
    struct alumno *a3, *a4, *a5, *a6;

    a3=&a0;
    Lectura(&a4);

        printf("\nIngrese la matricula del alumno 2:\t");
        scanf("%d",&(*a4).matricula);
        fflush(stdin);
        printf("\nIngrese el nombre del alumno 2:\t");
        gets((*a4).nombre);
        printf("\nIngrese la carrera del alumno 2:\t");
        gets((*a4).carrera);
        printf("\nIngrese el promedio del alumno 2:\t");
        scanf("%f",&(*a4).promedio);
        fflush(stdin);
        printf("\nIngrese direccion del alumno 2:\t");
        gets((*a4).direccion);

        Lectura(&a5);

        printf("\nIngrese la matricula del alumno 2:\t");
        scanf("%d",&(*a5).matricula);
        fflush(stdin);
        printf("\nIngrese el nombre del alumno 2:\t");
        gets((*a5).nombre);
        printf("\nIngrese la carrera del alumno 2:\t");
        gets((*a5).carrera);
        printf("\nIngrese el promedio del alumno 2:\t");
        scanf("%f",&(*a5).promedio);
        fflush(stdin);
        printf("\nIngrese direccion del alumno 2:\t");
        gets((*a5).direccion);

        Lectura(&a6);

        printf("\nIngrese la matricula del alumno 2:\t");
        scanf("%d",&(*a6).matricula);
        fflush(stdin);
        printf("\nIngrese el nombre del alumno 2:\t");
        gets((*a6).nombre);
        printf("\nIngrese la carrera del alumno 2:\t");
        gets((*a6).carrera);
        printf("\nIngrese el promedio del alumno 2:\t");
        scanf("%f",&(*a6).promedio);
        fflush(stdin);
        printf("\nIngrese direccion del alumno 2:\t");
        gets((*a6).direccion);


        printf("\n Datos del alumno 3\n");
        printf("\n%d\t%s\t%s\t%.2f\%s\n", a3->matricula, a3->nombre, a3->carrera, a3->promedio, a3->direccion);

        printf("\n Datos del alumno 4\n");
        printf("\n%d\t%s\t%s\t%.2f\%s\n", a4->matricula, a4->nombre, a4->carrera, a4->promedio, a4->direccion);

                printf("\n Datos del alumno 5\n");
        printf("\n%d\t%s\t%s\t%.2f\%s\n", a5->matricula, a5->nombre, a5->carrera, a5->promedio, a5->direccion);

                printf("\n Datos del alumno 3\n");
        printf("\n%d\t%s\t%s\t%.2f\%s\n", a6->matricula, a6->nombre, a6->carrera, a6->promedio, a6->direccion);





    return 0;
}
