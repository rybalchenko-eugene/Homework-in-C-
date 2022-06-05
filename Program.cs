// Программа про собаку и двух друзей
Console.WriteLine("Hello, World!");

int count = 0;
int dist = 10000;
int speed1 = 1;
int speed2 = 2;
int dogspeed = 5;
int friend = 1;
int time1;
while (dist > 10)
{
    if (friend == 1)
    {
        time1 = dist / (speed1 + dogspeed);
        friend = 2;
    }
    else
    {
        time1 = dist / (speed2 + dogspeed);
        friend = 1;
    }
    dist = dist - (speed1 + speed2) * time1;
    count += 1;
}
Console.WriteLine("Dog will run " + count + " times!");
