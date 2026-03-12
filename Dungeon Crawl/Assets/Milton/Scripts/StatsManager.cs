using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public static StatsManager instance;

    [Header("Player Stats")]
    public int playerDamage;
    public int playerMana;
    public int playerSpeed;

    public int playerMaxHP;
    public int playerCurrentHP;


       private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
}
