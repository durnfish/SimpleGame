using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpText : MonoBehaviour
{
    public GameObject enemy;
    public Text hpText;//체력 표시해줄 텍스트

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = EnemyObject.enemy.currentHp
                    + " / " 
                    + EnemyObject.enemy.maxHp;//체력 텍스트 업데이트
    }
}
