using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExpManager : MonoBehaviour
{
    private int level;//�÷��̾� ����
    [SerializeField] internal int exp;// �÷��̾� ����ġ
    [SerializeField] internal int maxExp;// �������� ���� �ʿ��� ����ġ
    [SerializeField]internal float expMult;// ����ġ ���
    [SerializeField] protected int IncreaseExpLimit;//�������ÿ� �����ϴ� ����ġ �ִ�ġ 

    void Awake()
    {
        exp = 0;
        maxExp = 50;//�ʱ� ����ġ�� �ʱ� �ʿ� ����ġ

    }

    // Start is called before the first frame update
    void Start()
    {
      
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
        level += 1;
        GameObject.Find("PlayerStatus").GetComponent<PlayerHpManager>().currentHp += 100;
        GameObject.Find("PlayerStatus").GetComponent<PlayerHpManager>().maxHp += 100;
        GameObject.Find("PlayerStatus").GetComponent<PlayerDamageManager>().damage += 10;
    }
}
