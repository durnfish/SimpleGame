using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    [SerializeField] AnimationClip battle, shop, treasure;
    Animation anim;
    int roomNum;

    private void Awake()
    {
        anim = GetComponent<Animation>();
    }
    private void Start()
    {
        Invoke("AnimationLoad", 0.2f);
    }
    void AnimationLoad()
    {
        switch (roomNum)
        {
            case 1:
                anim.clip = battle;
                Debug.Log("1");
                break;
            case 2:
                anim.clip = shop;
                Debug.Log("2");
                break;
            case 3:
                anim.clip = treasure;
                Debug.Log("3");
                break;
        }
    }
}
