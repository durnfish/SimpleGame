using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    public Animator anime;
    [SerializeField] GameObject enemy, battle;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
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
        EnemyAttack();
        PlayerDead();

        PlayerAtack();
        EnemyDead();
    }

    public void playerHeal()
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
        }
    }

    void EnemyDead()
    {
        if (EnemyObject.enemy.currentHp == 0)
        {
            PlayerObject.player.ExpGain(EnemyObject.enemy.exp);
            PlayerObject.player.gold += EnemyObject.enemy.gold;
            EnemyObject.enemy.currentHp = EnemyObject.enemy.maxHp;
            SceneManager.LoadScene("Map");
        }
    }
}
