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
        roomNum1 = 1; // 전투 씬 만드는데 쓸 test 버튼
        //roomNum1 = Random.Range(1, 4);
        roomNum2 = Random.Range(1, 4);
        roomNum3 = Random.Range(1, 4);
        Debug.Log(roomNum1);
        Debug.Log(roomNum2);
        Debug.Log(roomNum3);
    }

    void ChangeMapScene() // 기본 맵으로 돌아가는 함수
    {
        SceneManager.LoadScene("Map");
    }


    internal void SceneChaner(int x) //들어오는 숫자에 따라 방을 전환하는 함수
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
