using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{

    public Text hpText;//ü�� ǥ������ �ؽ�Ʈ

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = PlayerObject.player.currentHp 
                    + " / " 
                    + PlayerObject.player.maxHp;//ü�� �ؽ�Ʈ ������Ʈ
    }
}
