using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpText : MonoBehaviour
{
    public Text expText;//����ġ ǥ������ �ؽ�Ʈ
    public GameObject other;//����ġ �ؽ�Ʈ ǥ������ ���
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
        expText.text = (cexp+" / "+mexp);// ����ġ ������Ʈ
    }
}
