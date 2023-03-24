using System;
using static System.Console;

Clear();

double S = 65000; // 1 интервал замены масла
double qV = 1; // скорость появления загрязнений в масле мг/ 1000 км
double k = 4.0 / 7.0; // доля замещения масла 4 л из 7 л
double qAv = 0; // средняя концентраци загрязнений за период мг
int n = 5; // количество замен масла

double q1 = 0;
double q2 = 0;
double qAv1 = 0;

for (int i = 1; i <= n; i++)
{
    q2 = q1 + qV * S;
    qAv1 = (q1 + q2) / 2;
    qAv = (qAv1 + qAv * (i - 1)) / i;
    q1 = q2 * (1 - k);
    if (i == 1)
        S = S - 25000;
    if (i == 2 || i == 3)
        S = S - 10000;
    else
        S = S;

}

WriteLine($"{qAv,0:F0}");



