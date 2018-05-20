#include<stdio.h>
#include<math.h>

void main()
{
	int i, a, b, c;
	//double i, a, b, c;
	char z = 'a';
	double p, P;

	printf("Podaj dlugosci bokow trojkata a, b, c: ");
	scanf("%d%d%d", &a, &b, &c);
	//scanf("%lf%lf%lf", &a, &b, &c);

	p = 0.5*(a + b + c);
	if (a + b > c && a + c > b && b + c > a)
	{
		P = sqrt(p*(p - a)*(p - b)*(p - c));
		printf("Pole trojkata: %lf\n", P);
	}
	else
	{
		printf("Trojkat nie istnieje.\n");
	}
	printf("\n");

	for (i = 65; i < 91; i++)
	{
		printf("%d-%c\n", i, i);
	}
	printf("\n");
	i = 122;
	do
	{
		printf("%d-%c\n", i, i);
		i--;
	} while (i >= 97);
	printf("\n");
}