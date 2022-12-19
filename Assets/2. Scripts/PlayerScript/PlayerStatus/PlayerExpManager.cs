using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExpManager : MonoBehaviour
{
    public static PlayerExpManager playerExpManager;

    private int level;
    protected int exp;
    protected int maxExp;
    private float expMult;
    [SerializeField] protected int IncreaseExpLimit;//레벨업시에 증가하는 경험치 최대치 

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (playerExpManager == null)
        {
            playerExpManager = this;
        }
        else if (playerExpManager != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        exp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExpGain(int expGain) //경험치 획득 함수
    {
        exp += expGain;
        if (exp >= maxExp)
        {
            LevelUp();
            maxExp += IncreaseExpLimit;
        }
    }

    public void LevelUp() // 레벨업 함수
    {
        float hp = GetComponent<PlayerHpManager>().hp;
        int maxHp = GetComponent<PlayerHpManager>().maxHp;
        int damage = GetComponent<PlayerDamageManager>().damage;

        hp += 100;
        maxHp += 100;
        damage += 10;
        level += 1;
    }
}
