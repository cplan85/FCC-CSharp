/*
int heroHP = 10;
int monsterHP = 10;
bool heroTurn = true;


Random random = new Random();
int currentAttack = random.Next(1, 10);


do
{
    if (heroTurn) {
      monsterHP = monsterHP - currentAttack; 

      if (monsterHP <= 0) {
         Console.WriteLine($"Monster was damaged and lost {currentAttack} health and now has {monsterHP} health");
         Console.WriteLine($"Hero wins!");
      }
      else {
         Console.WriteLine($"Monster was damaged and lost {currentAttack} health and now has {monsterHP} health");
      }
      heroTurn = false;
      currentAttack = random.Next(1, 10);
    }

    else {
            heroHP = heroHP - currentAttack; 

      if (heroHP <= 0) {
         Console.WriteLine($"Hero was damaged and lost {currentAttack} health and now has {heroHP} health");
         Console.WriteLine($"Monster wins!");
      }
      else {
         Console.WriteLine($"Hero was damaged and lost {currentAttack} health and now has {heroHP} health");
      }
      heroTurn = true;
      currentAttack = random.Next(1, 10);
    }
} while (heroHP > 0 && monsterHP > 0);

*/