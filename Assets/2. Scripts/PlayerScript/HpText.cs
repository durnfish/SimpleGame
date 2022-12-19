using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{

    public GameObject hpText;//체력 표시해줄 텍스트
    public GameObject other;//체력 텍스트 표시해줄 대상
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
        hpText.GetComponent<Text>().text = (chp + " / " + mhp);//체력 텍스트 업데이트
    }
}
