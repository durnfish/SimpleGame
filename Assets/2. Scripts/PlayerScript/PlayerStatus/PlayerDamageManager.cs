using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageManager : MonoBehaviour
{
    public static PlayerDamageManager playerDamageManager;

    [SerializeField] internal int damage;
    [SerializeField] internal float attackSpeed;
    public int Damage { get { return damage; } set { damage = value; } }
    public float AttackSpeed { get { return attackSpeed; } set { AttackSpeed = value; } }


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (playerDamageManager == null)
        {
            playerDamageManager = this;
        }
        else if (playerDamageManager != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
