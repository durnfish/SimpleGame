using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoldManager : MonoBehaviour
{

    [SerializeField] protected int gold; //플레이어 소유 골드

    public int Gold { get { return gold; } set { gold = value; } }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
