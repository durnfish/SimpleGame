using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpText : MonoBehaviour
{
    public Text expText;//경험치 표시해줄 텍스트
    public GameObject other;//경험치 텍스트 표시해줄 대상
    int currentExp, maxExp;
    string cexp, mexp;
    // Start is called before the first frame update
    void Start()
    {
        currentExp = other.GetComponent<PlayerExpManager>().exp;
        maxExp = other.GetComponent<PlayerExpManager>().maxExp;
        cexp = currentExp.ToString();
        mexp = maxExp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        expText.text = (cexp+" / "+mexp);// 경험치 업데이트
    }
}
