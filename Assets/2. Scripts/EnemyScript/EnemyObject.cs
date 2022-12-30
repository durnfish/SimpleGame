using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : MonoBehaviour
{
    public static EnemyObject enemy;

    [SerializeField] internal float currentHp;//현재 체력
    [SerializeField] internal float maxHp;// 최대 체력
    [SerializeField] internal float enemyATKPoint;//몬스터 공격력
    [SerializeField] internal float attackSpeed;//몬스터 공격속도 구현 여부?
    [SerializeField] internal float level = 0;//몬스터 강함 척도
    [SerializeField] internal float exp; // 죽었을 때 플레이어에게 주는 경험치
    [SerializeField] internal float gold;// 몬스터가 떨구는 골드
    [SerializeField] Text levelText;

    private void Awake()
    {
        if(enemy == null)
        {
            enemy = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        level = PlayerObject.player.index / 3 + 1;
        currentHp = currentHp * level;
        maxHp = maxHp * level;
        enemyATKPoint = enemyATKPoint * level;
        exp = exp * level / 2;
        gold = gold * level / 2;
    }

    // Update is called once per frame
    void Update()
    {
        ShowLevel();
    }
    //체력 관리 함수
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
        if (currentHp > maxHp) currentHp = maxHp;
    }

    public void MaxHpDown(float changeHp)// 최대체력 감소
    {
        maxHp -= changeHp;
    }

    void ShowLevel()
    {
        levelText.text = "Lv: " + level;
    }
}
