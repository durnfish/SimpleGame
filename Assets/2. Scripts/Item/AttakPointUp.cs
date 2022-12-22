using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttakPointUp : MonoBehaviour
{
    public static AttakPointUp attakPointUp;

    int attakPoiontUp = 10;
    internal int price = 50;
    private void Awake()
    {
        if (attakPointUp == null)
        {
            attakPointUp = this;
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
    public void AttackPointUP()
    {
        PlayerObject.player.playerATKPoint += attakPoiontUp;
        Debug.Log(PlayerObject.player.playerATKPoint);
    }
}
