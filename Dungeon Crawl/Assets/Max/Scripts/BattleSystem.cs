using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { Inactive, Start, PlayerTurn, EnemyTurn, Won, Lost }
public class BattleSystem : MonoBehaviour
{
    public BattleState state;

    public Unit enemyEncounter;

    public List<Unit> enemies = new List<Unit>();


    void Start()
    {
        state = BattleState.Start;
        
        enemies.Add(new Goblin());
        enemies.Add(new Goblin());
        enemies.Add(new Goblin());
        enemies.Add(new Goblin());

        SetupBattle();
    }

    void SetupBattle()
    {
        Debug.Log("Battle Start");

        enemyEncounter = enemies[UnityEngine.Random.Range(0, enemies.Count)];

        state = BattleState.PlayerTurn;
        PlayerTurn();
    }

    void PlayerTurn()
    {
        Debug.Log("Player Turn");
    }
}