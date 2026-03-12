using UnityEngine;

public class Goblin : Unit
{
    private void Awake()
    {
        EnemyName = "Goblin";
        damage = 10;
        speed = 10;
        mana = 10;
        maxHP = 10;
        currentHP = maxHP;
    }
    public override int attack()
    {
        return damage;
    }
    public override void special()
    {
        
    }
}
