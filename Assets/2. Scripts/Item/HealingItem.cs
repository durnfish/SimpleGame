using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public static HealingItem healingItem;

    int healing = 50;
    internal int price = 15;

    private void Awake()
    {
        if (healingItem == null)
        {
            healingItem = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Healing()
    {
        PlayerObject.player.HpUpChanger(healing);
    }
}
