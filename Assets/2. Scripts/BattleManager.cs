using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    public Animator anime;

    [SerializeField] GameObject enemy;
    [SerializeField] GameObject player;
    //[SerializeField] GameObject enemyHpUpdate;
    //[SerializeField] GameObject playerHpUpdate;
    
    float currentPlayerHp;
    float currentEnemyHp;
    bool a = false;
    bool b = false;

  
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
            if (a==false)
            {
                Battle();
                Debug.Log(PlayerObject.player.currentHp);
                a = true;
            }
        }
        else
        {
            a = false;
        }

        if (Input.GetKey("a"))
        {
            if (b == false)
            {
                SceneManager.LoadScene("Map");
                b = true;
            }
        }
        else
        {
            b = false;
        }
    }

    void PlayerAtack()//플레이어가 공격할때, 몬스터 체력 감소 함수
    {
        EnemyObject.enemy.HpDownChanger(PlayerObject.player.playerATKPoint);
        //anime.SetTrigger("EnemyAtacked");
        currentEnemyHp = EnemyObject.enemy.currentHp;
    }

    void EnemyAttack()//몬스터가 공격할때, 플레이어 체력 감소 함수
    {
        PlayerObject.player.HpDownChanger(EnemyObject.enemy.enemyATKPoint);
        //anime.SetBool("EnemyAtack", true);
        currentPlayerHp = PlayerObject.player.currentHp;
    }

    public void Battle()//전투 함수
    {
            PlayerAtack();
           // enemyHpUpdate.GetComponent<HpSlider>().Update();
            Invoke("EnemyAttack", 1f);
           // playerHpUpdate.GetComponent<HpSlider>().Update();
    }
}
