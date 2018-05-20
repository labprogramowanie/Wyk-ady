#include <math.h>

double SredniaGeom(double nowe_liczby[], int n)
{
	double srednia = 1;
	double wynik;
	int i = 0;
	do
	{
		//srednia = srednia * nowe_liczby[i];
		srednia *= nowe_liczby[i];
		i++;
	} while (i < n);
	wynik = pow(srednia, 1.0 / n);
	return wynik;
}