int heroHealth      = 10;
int monsterHealth   = 10;

bool isHeroTurn = true;

Random random = new();
int damage = 0;

do
{
    damage = random.Next(1, 11);

    if (isHeroTurn)
        monsterHealth -= damage;
    else
        heroHealth -= damage;

    Console.WriteLine((isHeroTurn ? "Monster" : "Hero") + " was damaged and lost " + damage + " health and now has " + (isHeroTurn ? monsterHealth : heroHealth) + " health.");

    isHeroTurn = !isHeroTurn;

} while (monsterHealth > 0 && heroHealth > 0);

Console.WriteLine(isHeroTurn ? "Monster wins !" : "Hero wins !");