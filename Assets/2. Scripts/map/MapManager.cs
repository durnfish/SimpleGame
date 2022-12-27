using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    internal int roomNum1;
    internal int roomNum2;
    internal int roomNum3;
    [SerializeField] Animator slot1, slot2, slot3;
    void Start()
    {
        roomNum1 = Random.Range(1, 4);
        roomNum2 = Random.Range(1, 4);
        roomNum3 = Random.Range(1, 4);
        AnimationLoad(slot1, roomNum1);
        AnimationLoad(slot2, roomNum2);
        AnimationLoad(slot3, roomNum3);

    }
    void SceneChaner(int x) //������ ���ڿ� ���� ���� ��ȯ�ϴ� �Լ�
    {
        switch (x)
        {
            case 1:
                SceneManager.LoadScene("Battle");
                Debug.Log("1");
                break;
            case 2:
                SceneManager.LoadScene("Shop");
                Debug.Log("2");
                break;
            case 3:
                SceneManager.LoadScene("Treasure");
                Debug.Log("3");
                break;
        }
    }
    void AnimationLoad(Animator animation, int roomNum)
    {
        switch (roomNum)
        {
            case 1:
                animation.SetInteger("state",1);
                Debug.Log("1");
                break;
            case 2:
                animation.SetInteger("state",2);
                Debug.Log("2");
                break;
            case 3:
                animation.SetInteger("state",3);
                Debug.Log("3");
                break;
        }
    }

    public void ChangeRoomNumber1()//��ư1���� �� ü������ ���� �Լ�
    {
        SceneChaner(roomNum1);
    }

    public void ChangeRoomNumber2()//��ư2���� �� ü������ ���� �Լ�
    {
        SceneChaner(roomNum2);
    }

    public void ChangeRoomNumber3()//��ư 3���� �� ü������ ���� �Լ�
    {
        SceneChaner(roomNum3);
    }
}
