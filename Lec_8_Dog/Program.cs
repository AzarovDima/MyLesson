// ПОстчитать сколько раз собака пробежит между друзьями

int count = 0;
int distanse = 10000;
int firstFrendSpeed = 1;
int secondFrendSpeed = 2;
int dogSped = 5;
int friend = 2;
int time = 0;

while (distanse > 10)
{
    if (friend == 1)
    {
        time = distanse / (firstFrendSpeed + dogSped);
        friend = 2;
        distanse = distanse - (firstFrendSpeed + secondFrendSpeed) * time;
        count++;
    }
    else if (friend == 2)
    {
        time = distanse / (secondFrendSpeed + dogSped);
        friend = 1;
        distanse = distanse - (firstFrendSpeed + secondFrendSpeed) * time;
        count++;
    }
}
Console.WriteLine($"Собака пробежит {count} раз");
