using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    public GameObject idle, attacked, hpBar;
    [SerializeField] GameObject enemy, battle;
    [SerializeField] GameObject counter1, counter2, counter3;
    [SerializeField] GameObject Line1, Line2;
    readonly CursorScript cursor = CursorScript.cursor;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject.player.index += 1;
        index = PlayerObject.player.index;
        SetCounter(index);
        attacked.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            enemy.SetActive(false);
            battle.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            enemy.SetActive(true);
            battle.SetActive(true);
        }
    }

    void PlayerAtack()//플레이어가 공격할때, 몬스터 체력 감소 함수
    {
        EnemyObject.enemy.HpDownChanger(PlayerObject.player.playerATKPoint);
    }

    void EnemyAttack()//몬스터가 공격할때, 플레이어 체력 감소 함수
    {
        PlayerObject.player.HpDownChanger(EnemyObject.enemy.enemyATKPoint);
    }

    public void Battle()//전투 함수
    {
        if (!IsInvoking())
        {
            EnemyAttack();
            PlayerDead();

            PlayerAtack();
            Animation();
            EnemyDead();
        }
    }

    public void PlayerHeal()
    {
        EnemyAttack();
        PlayerDead();
        PlayerObject.player.currentHp += 30;
    }

    void PlayerDead()
    {
        if (PlayerObject.player.currentHp == 0)
        {
            PlayerObject.player.index = 0;
            PlayerObject.player.Reset();
            SceneManager.LoadScene("Map");
            cursor.DefautCursor();
        }
    }

    void EnemyDead()
    {
        if (EnemyObject.enemy.currentHp == 0)
        {
            hpBar.SetActive(false);
            Invoke("GoHome", 1.0f);
        }
    }
    void SetCounter(int index)
    {
        int counter = index % 3;
       
        switch (counter)
        {
            case 1:
                counter1.SetActive(true);
                Line1.SetActive(false);
                counter2.SetActive(false);
                Line2.SetActive(false);
                counter3.SetActive(false);
                break;
            case 2:
                counter1.SetActive(true);
                Line1.SetActive(true);
                counter2.SetActive(true);
                Line2.SetActive(false);
                counter3.SetActive(false);
                break;
            case 0:
                counter1.SetActive(true);
                Line1.SetActive(true);
                counter2.SetActive(true);
                Line2.SetActive(true);
                counter3.SetActive(true);
                break;
        }
    }
    void GoHome()
    {
        PlayerObject.player.ExpGain(EnemyObject.enemy.exp);
        PlayerObject.player.gold += EnemyObject.enemy.gold;
        EnemyObject.enemy.currentHp = EnemyObject.enemy.maxHp;
        SceneManager.LoadScene("Map");
    }
    void Animation()
    {
        AttackedState();
        Invoke("IdleState",1.2f);
    }
    void AttackedState()
    {
        idle.SetActive(false);
        attacked.SetActive(true);
    }
    void IdleState()
    {
        attacked.SetActive(false);
        idle.SetActive(true);
    }

}
