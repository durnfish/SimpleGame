using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public static Gold gold;

    int gainGold = 50;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        if (gold == null)
        {
            gold = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GainGold()
    {
        PlayerObject.player.gold += gainGold;
    }
}
