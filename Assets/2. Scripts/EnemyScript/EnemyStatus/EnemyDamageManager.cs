using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageManager : MonoBehaviour
{
    [SerializeField] protected int damage;//���� ���ݷ�
    [SerializeField] protected float attackSpeed;//���� ���ݼӵ� ���� ����?

    public int Damage { get { return damage; } set { damage = value; } }
    public float AttackSpeed { get { return attackSpeed; } set { attackSpeed = value; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
