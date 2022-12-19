using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontSestroyOnload : MonoBehaviour
{
    private static DontSestroyOnload instance = null; //씬이 전환되어도 남아있을 인스턴스들
     void Awake()
      {
        if (instance)
        {
            DestroyImmediate(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
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
