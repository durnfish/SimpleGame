using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExpManager : MonoBehaviour
{
    private int level;//플레이어 레벨
    [SerializeField] internal int exp;// 플레이어 경험치
    [SerializeField] internal int maxExp;// 레벨업을 위해 필요한 경험치
    [SerializeField]internal float expMult;// 경험치 배수
    [SerializeField] protected int IncreaseExpLimit;//레벨업시에 증가하는 경험치 최대치 

    void Awake()
    {
        exp = 0;
        maxExp = 50;//초기 경험치와 초기 필요 경험치

    }

    // Start is called before the first frame update
    void Start()
    {
      
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
        level += 1;
        GameObject.Find("PlayerStatus").GetComponent<PlayerHpManager>().currentHp += 100;
        GameObject.Find("PlayerStatus").GetComponent<PlayerHpManager>().maxHp += 100;
        GameObject.Find("PlayerStatus").GetComponent<PlayerDamageManager>().damage += 10;
    }
}
