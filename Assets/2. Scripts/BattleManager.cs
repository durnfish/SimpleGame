using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    public GameObject idle, attacked, hpBar;
    [SerializeField] GameObject enemy, battle;
    readonly CursorScript cursor = CursorScript.cursor;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
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

    void PlayerAtack()//�÷��̾ �����Ҷ�, ���� ü�� ���� �Լ�
    {
        EnemyObject.enemy.HpDownChanger(PlayerObject.player.playerATKPoint);
        //anime.SetTrigger("EnemyAtacked");
    }

    void EnemyAttack()//���Ͱ� �����Ҷ�, �÷��̾� ü�� ���� �Լ�
    {
        PlayerObject.player.HpDownChanger(EnemyObject.enemy.enemyATKPoint);
        //anime.SetBool("EnemyAtack", true);
    }

    public void Battle()//���� �Լ�
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
