using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoldManager : MonoBehaviour
{
    public static PlayerGoldManager playerGoldManager;

    [SerializeField] protected int gold;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (playerGoldManager == null)
        {
            playerGoldManager = this;
        }
        else if (playerGoldManager != this)
        {
            Destroy(gameObject);
        }
    }

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
