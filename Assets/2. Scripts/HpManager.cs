using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpManager : MonoBehaviour
{

    [SerializeField] internal int currentHp;//현재 체력
    [SerializeField] internal int maxHp;// 최대 체력

    public void HpUpChanger(int changeHp) //체력 회복 함수
    {
        if (currentHp <= maxHp)
        {
            currentHp += changeHp;
            if (currentHp > maxHp) currentHp = maxHp; //체력이 회복되었을 때, 회복된 체력이 최대체력을 넘지 못하게 한다.
        }
    }
    public void HpDownChanger(int changeHp)//체력 감소 함수
    {
        if (currentHp >= 0)
        {
            currentHp -= changeHp;
            if (currentHp < 0) currentHp = 0;//체력이 감소되었을 때, 감소된 체력이 0아래로 내려가지 않게 한다.
        }
    }
    public void MaxHpUp(int changeHp)// 최대체력 증가
    {
        maxHp += changeHp;
        if (currentHp > maxHp) currentHp = maxHp;
    }

    public void MaxHpDown(int changeHp)// 최대체력 감소
    {
        maxHp -= changeHp;
    }
}
