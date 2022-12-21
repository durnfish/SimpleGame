using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpSlider : MonoBehaviour
{
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
        float exp = PlayerObject.player.playerExp;
        float maxExp = PlayerObject.player.maxExp;
        expShow.value = exp / maxExp;//����ġ �����̴� ������Ʈ
    }
}
