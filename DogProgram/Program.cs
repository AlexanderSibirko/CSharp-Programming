int count = 0;
int personAspeed = 1;
int personBspeed = 2;
int dogspeed = 5;
int nextfriend =2;
// int time = 0;
// int distance = 10000;
// int totaltime = 0;
// int totaldistance = 0; 
double time = 0;
double distance = 10000;
double totaltime = 0;
double totaldistance = 0; 


while (distance > 10)
{
    if (nextfriend == 1)
    {
        time = distance/(personAspeed+dogspeed);
        nextfriend = 2;
    }
    else
    {
        time = distance/(personBspeed+dogspeed);
        nextfriend = 1;
    }
    //Console.WriteLine(distance);
    distance = distance - (personAspeed+personBspeed) * time;
    totaltime = totaltime + time;
    totaldistance = totaldistance + (personAspeed+personBspeed) * time;
    count++;
}

Console.WriteLine($"Собака перебежала от друга к другу {count} раз");
// Console.WriteLine($"Собака перебегала {totaltime} секунд");
// Console.WriteLine($"Собака перебежала {totaldistance} метров");
Console.WriteLine($"Собака перебегала {Math.Round(totaltime,4)} секунд");
Console.WriteLine($"Собака перебежала {Math.Round(totaldistance,2)} метров");
