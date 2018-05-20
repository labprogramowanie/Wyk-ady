#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <string.h>

void WpiszDane(char*, char*, double, int);
void WypiszDane();
void ZapisDoPliku();
void OdczytZPliku();

struct Samochod
{
	char* marka;
	char* kolor;
	double pojemnosc;
	int cena;
};

struct ListaSamochodow
{
	struct Samochod lista[10];
	int licznik;
} samochody;

//struct ListaSamochodow samochody;

void main()
{
	char marka[20];
	char kolor[20];
	double pojemnosc;
	int cena;

	samochody.licznik = 0;

	printf("Podaj marke: ");
	scanf("%s", marka);
	printf("Podaj kolor: ");
	scanf("%s", kolor);
	printf("Podaj pojemnosc: ");
	scanf("%lf", &pojemnosc);
	printf("Podaj cena: ");
	scanf("%i", &cena);
	WpiszDane(marka, kolor, pojemnosc, cena);
	printf("\n");

	printf("Podaj marke: ");
	scanf("%s", marka);
	printf("Podaj kolor: ");
	scanf("%s", kolor);
	printf("Podaj pojemnosc: ");
	scanf("%lf", &pojemnosc);
	printf("Podaj cena: ");
	scanf("%i", &cena);
	WpiszDane(marka, kolor, pojemnosc, cena);
	printf("\n");

	printf("Podaj marke: ");
	scanf("%s", marka);
	printf("Podaj kolor: ");
	scanf("%s", kolor);
	printf("Podaj pojemnosc: ");
	scanf("%lf", &pojemnosc);
	printf("Podaj cena: ");
	scanf("%i", &cena);
	WpiszDane(marka, kolor, pojemnosc, cena);
	printf("\n");

	WypiszDane();
	printf("\n");
	ZapisDoPliku();
	printf("\n");
	OdczytZPliku();
}

void WpiszDane(char* marka, char* kolor, double pojemnosc, int cena)
{
	samochody.lista[samochody.licznik].marka = malloc(strlen(marka) + 1);
	strcpy(samochody.lista[samochody.licznik].marka, marka);
	
	samochody.lista[samochody.licznik].kolor = malloc(strlen(kolor) + 1);
	strcpy(samochody.lista[samochody.licznik].kolor, kolor);

	samochody.lista[samochody.licznik].pojemnosc = pojemnosc;
	samochody.lista[samochody.licznik].cena = cena;

	samochody.licznik++;
}

void WypiszDane()
{
	int i = 0;
	while (i < samochody.licznik)
	{
		printf("%s, %s, %lf l, %i PLN\n",
			samochody.lista[i].marka,
			samochody.lista[i].kolor,
			samochody.lista[i].pojemnosc,
			samochody.lista[i].cena);
		i++;
	}
}

void ZapisDoPliku()
{
	FILE* plik;
	plik = fopen("samochody.txt", "w");

	int i = 0;
	while (i < samochody.licznik)
	{
		fprintf(plik, "%s %s %lf %i\n",
			samochody.lista[i].marka,
			samochody.lista[i].kolor,
			samochody.lista[i].pojemnosc,
			samochody.lista[i].cena);
		i++;
	}
	fclose(plik);
}

void OdczytZPliku()
{
	FILE* plik = fopen("samochody.txt", "r");
	char marka[20];
	char kolor[20];
	double pojemnosc;
	int cena;
	char separator;
	int koniec;

	while (1)
	{
		koniec = fscanf(plik, "%s", marka);
		if (koniec == EOF)
		{
			printf("\n");
			printf("*** %i ***\n", koniec);
			printf("\n");
			break;
		}
		fscanf(plik, "%c", &separator);
		fscanf(plik, "%s", kolor);
		fscanf(plik, "%c", &separator);
		fscanf(plik, "%lf", &pojemnosc);
		fscanf(plik, "%c", &separator);
		fscanf(plik, "%i", &cena);
		fscanf(plik, "%c", &separator);
		printf("%i: %s, %s, %lf l, %i PLN\n", koniec, marka, kolor, pojemnosc, cena);
	}

	fclose(plik);
}