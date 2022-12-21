using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpSlider : MonoBehaviour
{
    public Slider expShow; // 경험치 슬라이더가 표시 될 슬라이더 위치
    

    private void Awake()
    {
      
    }
    // Start is called before the first frame update
    void Start()
    {
        expShow.gameObject.SetActive(true); //경험치 슬라이더 활성화
        
    }

    // Update is called once per frame
    void Update()
    {
        float exp = PlayerObject.player.playerExp;
        float maxExp = PlayerObject.player.maxExp;
        expShow.value = exp / maxExp;//경험치 슬라이더 업데이트
    }
}
