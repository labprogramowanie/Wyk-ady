double SredniaArytm(double *nowe_liczby, int n)
{
	double srednia = 0;
	double wynik;
	int i = 0;
	do
	{
		//srednia += nowe_liczby[i];
		srednia = srednia + nowe_liczby[i];
		i++;
	} while (i < n);
	wynik = srednia / (1.0*n);
	return wynik;
}