#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <math.h>

double SredniaArytm(double*, int);
double SredniaGeom(double[], int);
void main()
{	
	char znaki[5] = { 'd','r','a','1','x' };
	int i = 0, n;
	char lancuch[] = "Programowanie w j. C";
	char* p;
	double* nowe_liczby;
	int wybor;
	double wynik;

	printf("Podaj dlugosc tablicy: ");
	scanf("%d", &n);
	nowe_liczby = malloc(sizeof(double)*n);
	while (i < n)
	{
		printf("Podaj element o ind. %d: ", i);
		scanf("%lf", &nowe_liczby[i]);
		i++;
	}
	for (i = 0; i < n; i++)
	{
		printf("nowe_liczby[%d] = %f\n", i, nowe_liczby[i]);
	}
	printf("Podaj wybor: ");
	scanf("%\i", &wybor);

	switch (wybor)
	{
		case 1:
		{
			wynik = SredniaArytm(nowe_liczby, n);
			printf("Sr. arytm. = %f\n", wynik);
			break;
		}
		case 2:
		{
			printf("Sr. geom. = %f\n", SredniaGeom(nowe_liczby, n));
			break;
		}
		default:
		{
			printf("Bledny wybor!\n");
			break;
		}
	}
	printf("\n");

	printf("Tablica znakowa:\n");
	while (i < 5)
	{
		printf("%c ", znaki[i]);
		i++;
	}
	printf("\n");
	
	printf("Operacje na lancuchach:\n");
	printf("Lancuch: %s\n", lancuch);
	lancuch[19] = 'Q';
	printf("\n");
	printf("Lancuch: %s\n", lancuch);
	printf("\n");
	i = 10;
	while (lancuch[i] != NULL)
	{
		printf("%c\n", lancuch[i]);
		i++;
	}
	printf("\n");

	printf("Praca z wskaznikiem:\n");
	p = &znaki[0];
	printf("%c\n", *p);
	p = &znaki[2];
	printf("%c\n", *p);
	printf("\n");
	p = lancuch; //p = &lancuch[0];
	for (i = 0; i < 5; i++)
	{
		printf("%c", p[i]);
	}
	printf("\n");
}
