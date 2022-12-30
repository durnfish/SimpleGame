using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : MonoBehaviour
{
    public static EnemyObject enemy;

    [SerializeField] internal float currentHp;//���� ü��
    [SerializeField] internal float maxHp;// �ִ� ü��
    [SerializeField] internal float enemyATKPoint;//���� ���ݷ�
    [SerializeField] internal float attackSpeed;//���� ���ݼӵ� ���� ����?
    [SerializeField] internal float level = 0;//���� ���� ô��
    [SerializeField] internal float exp; // �׾��� �� �÷��̾�� �ִ� ����ġ
    [SerializeField] internal float gold;// ���Ͱ� ������ ���
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

    void ShowLevel()
    {
        levelText.text = "Lv: " + level;
    }
}
