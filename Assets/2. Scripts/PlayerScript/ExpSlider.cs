using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpSlider : PlayerExpManager
{
    public GameObject other; // ����ġ �����̴� ǥ�� �� ���
    public Slider expShow; // ����ġ �����̴��� ǥ�� �� �����̴� ��ġ

    private void Awake()
    {
      
    }
    // Start is called before the first frame update
    void Start()
    {
        expShow.gameObject.SetActive(true); //����ġ �����̴� Ȱ��ȭ
        
    }

    // Update is called once per frame
    void Update()
    {
        expShow.value = (float)exp / maxExp;//����ġ �����̴� ������Ʈ
    }
}
