using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageManager : MonoBehaviour
{

    [SerializeField] internal int damage;//�÷��̾� ���ݷ�
    [SerializeField] internal float attackSpeed;//�÷��̾� ���ݼӵ�
    public int Damage { get { return damage; } set { damage = value; } }
    public float AttackSpeed { get { return attackSpeed; } set { AttackSpeed = value; } }


    void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
