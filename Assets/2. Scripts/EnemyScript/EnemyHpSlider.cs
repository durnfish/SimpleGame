using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpSlider : MonoBehaviour
{

    public Slider hpshow;//ü�� �����̴��� ǥ�� �� �����̴� ��ġ

    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        hpshow.gameObject.SetActive(true);//ü�� �����̴� Ȱ��ȭ
      

    }

    // Update is called once per frame
    internal void Update()
    {
       
        hpshow.value = EnemyObject.enemy.currentHp/EnemyObject.enemy.maxHp; // ü�� �����̴� ������Ʈ
    }
}
