using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemMagnager : MonoBehaviour
{
    int itemNum;
    public Image image;
    public Sprite atk;
    public Sprite maxHpUp;
    public Sprite heal;
    public Sprite gold;
    // Start is called before the first frame update
    void Start()
    {
        itemNum = Random.Range(1, 5);
        ItemSpwan();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemSpwan()
    {
        switch (itemNum)
        {
            case 1:image.sprite = atk;
                break;
            case 2:image.sprite = maxHpUp;
                break;
            case 3:image.sprite = heal;
                break;
            case 4:image.sprite = gold;
                break;
        }
    }

    public void get()
    {
        switch (itemNum)
        {
            case 1:AttakPointUp.attakPointUp.AttackPointUP();
                break;
            case 2:HpPointUp.hpPointUp.MaxHpUp();
                break;
            case 3:HealingItem.healingItem.Healing();
                break;
            case 4:Gold.gold.GainGold();
                break;
        }
        SceneManager.LoadScene("map");
    }
}
