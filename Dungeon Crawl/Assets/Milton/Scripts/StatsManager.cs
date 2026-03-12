using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public static StatsManager instance;

    [Header("Player Stats")]
    public int damage;
    public int intelligence;
    public int speed;

    public int maxHealth;
    public int currentHealth;


       private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
}
