using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public static StatsManager instance;

    [Header("Player Stats")]
    public int playerDamage;
    public int PLayerInt;
    public int playerSpeed;

    public int playerMaxHealth;
    public int playerCurrentHealth;


       private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
}
