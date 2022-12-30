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

    // ���� ���� �ʵ�
    int level;
    internal int index = 0;//���� ī���� ��

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
    }

    public void MaxHpDown(float changeHp)// �ִ�ü�� ����
    {
        maxHp -= changeHp;
    }

    //����ġ ���
    public void ExpGain(float expGain) //����ġ ȹ�� �Լ�
    {
        playerExp += expGain * expMulti;
        if (playerExp >= maxExp)
        {
            LevelUp();
            playerExp = 0;
            maxExp += 30;
        }
    }

    public void LevelUp() // ������ �Լ�
    {
        level += 1;
        currentHp += 25;
        maxHp += 50;
        playerATKPoint += 10;
    }
    //���� �ʱ�ȭ
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
