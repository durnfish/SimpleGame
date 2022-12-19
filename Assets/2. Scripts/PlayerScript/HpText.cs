using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{

    public GameObject hpText;//ü�� ǥ������ �ؽ�Ʈ
    public GameObject other;//ü�� �ؽ�Ʈ ǥ������ ���
    int currentHp, maxHp;
    string chp, mhp;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = other.GetComponent<HpManager>().currentHp;
        maxHp = other.GetComponent<HpManager>().maxHp;
        chp = currentHp.ToString();
        mhp = maxHp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        hpText.GetComponent<Text>().text = (chp + " / " + mhp);//ü�� �ؽ�Ʈ ������Ʈ
    }
}
