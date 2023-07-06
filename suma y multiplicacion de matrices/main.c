#include <stdio.h>
#include <stdlib.h>
#include <math.h>


#define ROWS 3
#define COLS 3

void imprimirMatriz(int matriz[ROWS][COLS]);
void sumarMatrices(int matriz1[ROWS][COLS], int matriz2[ROWS][COLS], int resultado[ROWS][COLS]);
void productoMatrices(int matriz1[ROWS][COLS], int matriz2[ROWS][COLS], int resultado[ROWS][COLS]);



int main() {
    int matriz1[ROWS][COLS] = {{2, 5, 8},
                               {3, 6, 9},
                               {4, 7, 10}};

    int matriz2[ROWS][COLS] = {{1, 10, 100},
                               {2, 20, 10},
                               {3, 30, 15}};

    int resultado[ROWS][COLS];

    sumarMatrices(matriz1, matriz2, resultado);

    printf("Matriz resultante:\n");
    imprimirMatriz(resultado);
}

void sumarMatrices(int matriz1[ROWS][COLS], int matriz2[ROWS][COLS], int resultado[ROWS][COLS]) {
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            resultado[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }
}

void productoMatrices(int matriz1[ROWS][COLS], int matriz2[ROWS][COLS], int resultado[ROWS][COLS]) {
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            resultado[i][j] = matriz1[i][j] * matriz2[i][j];
        }
    }
}

