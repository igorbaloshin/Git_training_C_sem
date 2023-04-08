using System;
using static System.Console;

Clear();

double distance = 300;
double fTS = 50;
double sTS = 100;
double rS = 150;
int train = 2;
double time = 0;
double timesum = 0;
double distance_r = 0;
int k = 0;

while(distance > 0)
{
    if(train == 2)
    {
        time = distance/(sTS + rS);
        train = 1;
    }
    if(train == 1)
    {
        time = distance/(fTS + rS);
        train = 2;
    }
    
    distance = distance - (fTS + sTS) * time;
    timesum += time;
    k++;

}
distance_r = timesum * rS;

WriteLine($"{distance_r, 2:F0}");

WriteLine(k);