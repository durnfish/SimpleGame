using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public static PlayerObject player;

    public float currentHp;
    public float maxHp;
    public float playerATKPoint;
    public float playerATKSpeed;
    public float playerExp;
    public float maxExp;
    public float expMulti;
    public float gold;

    // 레벨 관련 필드
    int level;
    internal int index = 0;//몬스터 카운터 수

    private void Awake()
    {
        if (player == null)
        {
            player = this;
        }
        Reset();
    }

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //체력 관련 함수
    public void HpUpChanger(float changeHp) //체력 회복 함수
    {
        if (currentHp <= maxHp)
        {
            currentHp += changeHp;
            if (currentHp > maxHp) currentHp = maxHp; //체력이 회복되었을 때, 회복된 체력이 최대체력을 넘지 못하게 한다.
        }
    }
    public void HpDownChanger(float changeHp)//체력 감소 함수
    {
        if (currentHp >= 0)
        {
            currentHp -= changeHp;
            if (currentHp < 0) currentHp = 0;//체력이 감소되었을 때, 감소된 체력이 0아래로 내려가지 않게 한다.
        }
    }
    public void MaxHpUp(float changeHp)// 최대체력 증가
    {
        maxHp += changeHp;
    }

    public void MaxHpDown(float changeHp)// 최대체력 감소
    {
        maxHp -= changeHp;
    }

    //경험치 블록
    public void ExpGain(float expGain) //경험치 획득 함수
    {
        playerExp += expGain * expMulti;
        if (playerExp >= maxExp)
        {
            LevelUp();
            playerExp = 0;
            maxExp += 30;
        }
    }

    public void LevelUp() // 레벨업 함수
    {
        level += 1;
        currentHp += 25;
        maxHp += 50;
        playerATKPoint += 10;
    }
    //게임 초기화
    public void Reset()
    {
        currentHp = 100;
        maxHp = 100;
        playerATKPoint = 10;
        playerATKSpeed = 1;
        playerExp = 0;
        maxExp = 30;
        expMulti = 1;
        gold = 50;

    }
}
