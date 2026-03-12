using System;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public string EnemyName;

    public int damage;
    public int mana;
    public int speed;
    public int maxHP;
    public int currentHP;

    public virtual int attack()
        {
            return damage;
        }
    public abstract void special();
}
