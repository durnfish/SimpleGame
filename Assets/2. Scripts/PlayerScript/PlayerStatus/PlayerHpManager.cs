using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHpManager : HpManager
{
    public void HpChanger(int changeHp)
    {
        if (hp <= maxHp)
        {
            hp += changeHp;
            if (hp > maxHp) hp = maxHp;
        }
    }
    // Start is called before the first frame update
    public void MaxHpUp(int changeHp)
    {
        maxHp += changeHp;
    }

    public void MaxHpDown(int changeHp)
    {
        maxHp -= changeHp;
    }
}
