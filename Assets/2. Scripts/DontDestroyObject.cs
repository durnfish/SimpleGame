using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObject : MonoBehaviour
{
    public static DontDestroyObject dontDestroyObject;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (dontDestroyObject == null)
        {
            dontDestroyObject = this;
        }
        else if (dontDestroyObject != this)
        {
            Destroy(gameObject);
        }
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
