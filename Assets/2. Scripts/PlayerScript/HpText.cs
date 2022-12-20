using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{

    public Text hpText;//체력 표시해줄 텍스트

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = PlayerObject.player.currentHp 
                    + " / " 
                    + PlayerObject.player.maxHp;//체력 텍스트 업데이트
    }
}
