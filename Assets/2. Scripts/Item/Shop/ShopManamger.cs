using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManamger : MonoBehaviour
{
    int itemSlot1, itemSlot2, itemSlot3;
    public Image image1, image2, image3;
    public Sprite atk;
    public Sprite maxHpUp;
    public Sprite heal;
    public Text price1, price2, price3;
    public GameObject slot1, slot2, slot3;
    [SerializeField] Item ATK, MaxHp;
    [SerializeField] GameObject items;
    InventoryManager inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = InventoryManager.inventory;
        itemSlot1 = Random.Range(1, 4);
        Invoke("",0.01f);
        itemSlot2 = Random.Range(1, 4);
        Invoke("", 0.01f);
        itemSlot3 = Random.Range(1, 4);

        ItemSlot(itemSlot1, image1, price1);
        ItemSlot(itemSlot2, image2, price2);
        ItemSlot(itemSlot3, image3, price3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            items.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            items.SetActive(true);

        }
    }
    void ItemSlot(int itemSlotNum, Image image, Text text)
    {
        switch (itemSlotNum)
        {
            case 1: image.sprite = atk;
                text.text = AttakPointUp.attakPointUp.price+" gold";
                break;
            case 2: image.sprite = maxHpUp;
                text.text = HpPointUp.hpPointUp.price + " gold";
                break;
            case 3: image.sprite = heal;
                text.text = HealingItem.healingItem.price + " gold";
                break;
        }
    }
    void Perchase(int itemSlotNum)
    {
        switch (itemSlotNum)
        {
            case 1:
                if (PlayerObject.player.gold >= AttakPointUp.attakPointUp.price)
                {
                    PlayerObject.player.gold -= AttakPointUp.attakPointUp.price;
                    AttakPointUp.attakPointUp.AttackPointUP();
                    inventory.AddItem(ATK);
                }
                break;
            case 2:
                if (PlayerObject.player.gold >= HpPointUp.hpPointUp.price)
                {
                    PlayerObject.player.gold -= HpPointUp.hpPointUp.price;
                    HpPointUp.hpPointUp.MaxHpUp();
                    inventory.AddItem(MaxHp);
                }
                break;
            case 3:
                if (PlayerObject.player.gold >= HealingItem.healingItem.price)
                {
                    PlayerObject.player.gold -= HealingItem.healingItem.price;
                    HealingItem.healingItem.Healing();
                }
                break;
        }
    }
    public void Slot1()
    {
        Perchase(itemSlot1);
        slot1.SetActive(false);
    }
    public void Slot2()
    {
        Perchase(itemSlot2);
        slot2.SetActive(false);
    }
    public void Slot3()
    {
        Perchase(itemSlot3);
        slot3.SetActive(false);
    }
    public void shopExit()
    {
        SceneManager.LoadScene("Map");
        slot1.SetActive(false);
        slot2.SetActive(false);
        slot3.SetActive(false);
    }
}
