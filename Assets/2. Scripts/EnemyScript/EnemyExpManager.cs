using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExpManager : MonoBehaviour
{
    [SerializeField] protected int level;
    [SerializeField] protected int exp; // �׾��� �� �÷��̾�� �ִ� ����ġ

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
