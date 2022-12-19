using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSlider : MonoBehaviour
{
    public GameObject other;//ü�� �����̴��� ǥ���� ���
    internal int currentHp;
    internal int maxHp;

    public Slider hpshow;//ü�� �����̴��� ǥ�� �� �����̴� ��ġ

    void Awake()
    {
        currentHp = other.GetComponent<HpManager>().currentHp;
        maxHp = other.GetComponent<HpManager>().maxHp;
    }
    // Start is called before the first frame update
    void Start()
    {
        hpshow.gameObject.SetActive(true);//ü�� �����̴� Ȱ��ȭ
      

    }

    // Update is called once per frame
    internal void Update()
    {
        hpshow.value = (float)currentHp / maxHp; // ü�� �����̴� ������Ʈ
    }
}
