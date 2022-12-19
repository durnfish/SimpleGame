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
    [SerializeField] protected int IncreaseExpLimit;//�������ÿ� �����ϴ� ����ġ �ִ�ġ 

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

    public void ExpGain(int expGain) //����ġ ȹ�� �Լ�
    {
        exp += expGain;
        if (exp >= maxExp)
        {
            LevelUp();
            maxExp += IncreaseExpLimit;
        }
    }

    public void LevelUp() // ������ �Լ�
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
