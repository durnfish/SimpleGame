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

    void PlayerAtack()//플레이어가 공격할때, 몬스터 체력 감소 함수
    {
        EnemyObject.enemy.HpDownChanger(PlayerObject.player.playerATKPoint);
        //anime.SetTrigger("EnemyAtacked");
    }

    void EnemyAttack()//몬스터가 공격할때, 플레이어 체력 감소 함수
    {
        PlayerObject.player.HpDownChanger(EnemyObject.enemy.enemyATKPoint);
        //anime.SetBool("EnemyAtack", true);
    }

    void Battle()//전투 함수
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
