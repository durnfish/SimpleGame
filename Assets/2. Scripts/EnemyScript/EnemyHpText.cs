using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpText : MonoBehaviour
{
    public GameObject enemy;
    public Text hpText;//ü�� ǥ������ �ؽ�Ʈ

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = EnemyObject.enemy.currentHp
                    + " / " 
                    + EnemyObject.enemy.maxHp;//ü�� �ؽ�Ʈ ������Ʈ
    }
}
