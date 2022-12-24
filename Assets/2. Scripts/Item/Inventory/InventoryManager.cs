using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryManager : MonoBehaviour
{
    public static InventoryManager inventory;

    public List<Item> items;

    [SerializeField]
    private Transform slotParent;

    [SerializeField]
    private Slot[] slots;

    [SerializeField] GameObject popUp, playerUi;
    [SerializeField] Text atk, maxHp;

    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<Slot>();
    }
     void Awake()
    {
        if(inventory == null)
        {
            inventory = this;
        }
        
        Debug.Log(slots.Length);
        FreshSlot();
    }

    private void Start()
    {
        popUp.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)){
            popUp.SetActive(true);
            playerUi.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            popUp.SetActive(false);
            playerUi.SetActive(true);
        }

        playerStatusShow();
    }

    public void FreshSlot()
    {
        int i = 0;
        for (; i < items.Count && i < slots.Length; i++)
        {
            slots[i].item = items[i];
        }
        for (; i < slots.Length; i++)
        {
            slots[i].item = null;
        }
    }
    public void AddItem(Item _item)
    {
        if(items.Count < slots.Length)
        {
            items.Add(_item);
            FreshSlot();
        }
        else
        {
            print("������ ���� �� �ֽ��ϴ�.");
        }
    }
    void playerStatusShow()
    {
        atk.text = "���ݷ�: "+ PlayerObject.player.playerATKPoint;
        maxHp.text = "�ִ� ü��:" + PlayerObject.player.maxHp;
    }
}
