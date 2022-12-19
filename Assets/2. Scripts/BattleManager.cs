using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public Animator anime;

    [SerializeField] GameObject enemy;
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemyHpUpdate;
    [SerializeField] GameObject playerHpUpdate;
    
    int currentPlayerHp;
    int currentEnemyHp;

  
    // Start is called before the first frame update
    void Start()
    {
        //test
        player.GetComponent<PlayerHpManager>().currentHp -= enemy.GetComponent<EnemyDamageManager>().Damage;
        currentPlayerHp = player.GetComponent<PlayerHpManager>().currentHp;
        Debug.Log(currentPlayerHp);
        playerHpUpdate.GetComponent<HpSlider>().currentHp = currentPlayerHp;
        playerHpUpdate.GetComponent<HpSlider>().Update();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerAtack()//�÷��̾ �����Ҷ�, ���� ü�� ���� �Լ�
    {
        enemy.GetComponent<EnemyHpManager>().HpDownChanger(player.GetComponent<PlayerDamageManager>().damage);
        //anime.SetTrigger("EnemyAtacked");
        currentEnemyHp = enemy.GetComponent<EnemyHpManager>().currentHp;
    }

    void EnemyAttack()//���Ͱ� �����Ҷ�, �÷��̾� ü�� ���� �Լ�
    {
        player.GetComponent<PlayerHpManager>().HpDownChanger(enemy.GetComponent<EnemyDamageManager>().Damage);
        //anime.SetBool("EnemyAtack", true);
        currentPlayerHp = player.GetComponent<PlayerHpManager>().currentHp;
    }

    public void Battle()//���� �Լ�
    {
        if (Input.GetKey("x"))
        {
            PlayerAtack();
            enemyHpUpdate.GetComponent<HpSlider>().currentHp = currentEnemyHp;
            enemyHpUpdate.GetComponent<HpSlider>().Update();
            Invoke("EnemyAttack",1f);
            playerHpUpdate.GetComponent<HpSlider>().currentHp = currentPlayerHp;
            playerHpUpdate.GetComponent<HpSlider>().Update();
        }
    }
}
