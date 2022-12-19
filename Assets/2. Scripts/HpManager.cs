using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpManager : MonoBehaviour
{

    [SerializeField] internal int currentHp;//���� ü��
    [SerializeField] internal int maxHp;// �ִ� ü��

    public void HpUpChanger(int changeHp) //ü�� ȸ�� �Լ�
    {
        if (currentHp <= maxHp)
        {
            currentHp += changeHp;
            if (currentHp > maxHp) currentHp = maxHp; //ü���� ȸ���Ǿ��� ��, ȸ���� ü���� �ִ�ü���� ���� ���ϰ� �Ѵ�.
        }
    }
    public void HpDownChanger(int changeHp)//ü�� ���� �Լ�
    {
        if (currentHp >= 0)
        {
            currentHp -= changeHp;
            if (currentHp < 0) currentHp = 0;//ü���� ���ҵǾ��� ��, ���ҵ� ü���� 0�Ʒ��� �������� �ʰ� �Ѵ�.
        }
    }
    public void MaxHpUp(int changeHp)// �ִ�ü�� ����
    {
        maxHp += changeHp;
        if (currentHp > maxHp) currentHp = maxHp;
    }

    public void MaxHpDown(int changeHp)// �ִ�ü�� ����
    {
        maxHp -= changeHp;
    }
}
