using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPointUp : MonoBehaviour
{
    public static HpPointUp hpPointUp;

    int maxHpUp = 30;
    internal int price = 30;

    private void Awake()
    {
        if (hpPointUp == null)
        {
            hpPointUp = this;
        }
        Debug.Log("awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MaxHpUp()
    {
        PlayerObject.player.MaxHpUp(maxHpUp);
    }
}
