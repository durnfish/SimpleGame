using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    internal int roomNum1;
    internal int roomNum2;
    internal int roomNum3;

    void Start()
    {
        roomNum1 = 1; // ���� �� ����µ� �� test ��ư
        //roomNum1 = Random.Range(1, 4);
        roomNum2 = Random.Range(1, 4);
        roomNum3 = Random.Range(1, 4);
        Debug.Log(roomNum1);
        Debug.Log(roomNum2);
        Debug.Log(roomNum3);
    }

    void ChangeMapScene() // �⺻ ������ ���ư��� �Լ�
    {
        SceneManager.LoadScene("Map");
    }


    internal void SceneChaner(int x) //������ ���ڿ� ���� ���� ��ȯ�ϴ� �Լ�
    {
        switch (x)
        {
            case 1:
                SceneManager.LoadScene("Battle");
                break;
            case 2:
                SceneManager.LoadScene("Shop");
                break;
            case 3:
                SceneManager.LoadScene("Treasure");
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
