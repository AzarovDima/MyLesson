// ПОстчитать сколько раз собака пробежит между друзьями

int count = 0;
int distanse = 10000;
int firstFrendSpeed = 1;
int secondFrendSpeed = 2;
int dogSped = 4;
int friend = 1;
friend == 2;

while (distanse > 5)
{
    if (friend == 1)
    {
        t = distanse / (firstFrendSpeed + dogSped);
        friend == 2;
    }
    else (friend = 2);
    {
        t = distanse / (secondFrendSpeed + dogSped);
        friend == 1;
    }
    distanse = distanse - (firstFrendSpeed + secondFrendSpeed) * t;
    count++;
}
Console.WriteLine(count);



