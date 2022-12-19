using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontSestroyOnload : MonoBehaviour
{
    private static DontSestroyOnload instance = null; //���� ��ȯ�Ǿ �������� �ν��Ͻ���
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
