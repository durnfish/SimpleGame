using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpSlider : MonoBehaviour
{

    public Slider hpshow;//체력 슬라이더가 표시 될 슬라이더 위치

    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        hpshow.gameObject.SetActive(true);//체력 슬라이더 활성화
      

    }

    // Update is called once per frame
    internal void Update()
    {
       
        hpshow.value = EnemyObject.enemy.currentHp/EnemyObject.enemy.maxHp; // 체력 슬라이더 업데이트
    }
}
