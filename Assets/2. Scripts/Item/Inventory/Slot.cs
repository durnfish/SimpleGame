using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] GameObject objectNull; //�������� ���� �� ��Ȱ ��ȭ �� ����
    [SerializeField] Image image;
    private Item _item;

    public Item item
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item != null)
            {
                objectNull.SetActive(true);
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
                //objectNull.SetActive(false);// ��Ȱ��ȭ
            }
        }
    }
}
