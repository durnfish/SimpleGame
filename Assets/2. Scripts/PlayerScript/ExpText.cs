using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpText : MonoBehaviour
{
    public Text expText;//����ġ ǥ������ �ؽ�Ʈ
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        expText.text = PlayerObject.player.playerExp 
                     + " / "
                     + PlayerObject.player.maxExp;// ����ġ ������Ʈ
    }
}
