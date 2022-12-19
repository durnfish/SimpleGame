using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExpManager : MonoBehaviour
{
    [SerializeField] protected int level;
    [SerializeField] protected int exp; // 죽었을 때 플레이어에게 주는 경험치

    public int Exp { get { return exp; } set { exp = value; } }
    public int Level { get { return level; } set { level = value; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
