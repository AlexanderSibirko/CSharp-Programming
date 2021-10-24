int count = 0;
int personAspeed = 1;
int personBspeed = 2;
int dogspeed = 5;
double distance = 10000;
int nextfriend =2;
double time = 0;

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
    distance = distance - (personAspeed+personBspeed) * time;
    count++;
}

Console.WriteLine($"Собака перебежала от друга к другу {count} раз");
