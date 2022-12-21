using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    public Animator anime;
    bool battleCheck = false;

  
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("x"))
        {
            if (battleCheck==false)
            {
                Battle();
                battleCheck = true;
            }
        }
        else
        {
            battleCheck = false;
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

    void Battle()//���� �Լ�
    {
        EnemyAttack();
        PlayerDead();

        PlayerAtack();
        EnemyDead();
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
            EnemyObject.enemy.currentHp = EnemyObject.enemy.maxHp;
            SceneManager.LoadScene("Map");
        }
    }
}
