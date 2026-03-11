using UnityEngine;


[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Unit : ScriptableObject
{
    public string EnemyName;

    public int damage;
    public int mana;
    public int speed; 
    public int maxHP;
    public int currentHP;
}
