using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSlider : MonoBehaviour
{
    public GameObject other;//ü�� �����̴��� ǥ���� ���
    float currentHp;
    float maxHp;

    public Slider hpshow;//ü�� �����̴��� ǥ�� �� �����̴� ��ġ

    // Start is called before the first frame update
    void Start()
    {
        hpshow.gameObject.SetActive(true);//ü�� �����̴� Ȱ��ȭ
      

    }

    // Update is called once per frame
    internal void Update()
    {
        currentHp = PlayerObject.player.currentHp;
        maxHp = PlayerObject.player.maxHp;
        hpshow.value = (float)currentHp / maxHp; // ü�� �����̴� ������Ʈ
    }
}
