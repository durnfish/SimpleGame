using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject map;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            map.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            map.SetActive(true);
        }
    }

    
}
