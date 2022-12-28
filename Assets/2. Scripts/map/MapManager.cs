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
        AllLoad();
    }
    void SceneChaner(int x) //들어오는 숫자에 따라 방을 전환하는 함수
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
    void AnimationLoad(Animator slot, int roomNum)
    {
        switch (roomNum)
        {
            case 1:
                slot.SetInteger("state",1);
                Debug.Log("1");
                break;
            case 2:
                slot.SetInteger("state", 2);
                Debug.Log("2");
                break;
            case 3:
                slot.SetInteger("state", 3);
                Debug.Log("3");
                break;
        }
    }
    void AllLoad()
    {
        AnimationLoad(slot1, roomNum1);
        AnimationLoad(slot2, roomNum2);
        AnimationLoad(slot3, roomNum3);
    }

    public void ChangeRoomNumber1()//버튼1에서 씬 체인지를 위한 함수
    {
        SceneChaner(roomNum1);
    }

    public void ChangeRoomNumber2()//버튼2에서 씬 체인지를 위한 함수
    {
        SceneChaner(roomNum2);
    }

    public void ChangeRoomNumber3()//버튼 3에서 씬 체인지를 위한 함수
    {
        SceneChaner(roomNum3);
    }
}
