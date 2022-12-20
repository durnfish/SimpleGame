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
    public float exp;
    public float maxExp;
    public float expMulti;
    public float gold;

    // ���� ���� �ʵ�
    int level;

    private void Awake()
    {
        if (player == null)
        {
            player = this;
        }
    }

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ü�� ���� �Լ�
    public void HpUpChanger(float changeHp) //ü�� ȸ�� �Լ�
    {
        if (currentHp <= maxHp)
        {
            currentHp += changeHp;
            if (currentHp > maxHp) currentHp = maxHp; //ü���� ȸ���Ǿ��� ��, ȸ���� ü���� �ִ�ü���� ���� ���ϰ� �Ѵ�.
        }
    }
    public void HpDownChanger(float changeHp)//ü�� ���� �Լ�
    {
        if (currentHp >= 0)
        {
            currentHp -= changeHp;
            if (currentHp < 0) currentHp = 0;//ü���� ���ҵǾ��� ��, ���ҵ� ü���� 0�Ʒ��� �������� �ʰ� �Ѵ�.
        }
    }
    public void MaxHpUp(float changeHp)// �ִ�ü�� ����
    {
        maxHp += changeHp;
        if (currentHp > maxHp) currentHp = maxHp;
    }

    public void MaxHpDown(float changeHp)// �ִ�ü�� ����
    {
        maxHp -= changeHp;
    }

    //����ġ ���
    public void ExpGain(float expGain) //����ġ ȹ�� �Լ�
    {
        exp += expGain;
        if (exp >= maxExp)
        {
            LevelUp();
            maxExp += 50;
        }
    }

    public void LevelUp() // ������ �Լ�
    {
        level += 1;
        currentHp += 100;
        maxHp += 100;
        playerATKPoint += 10;
    }
}
