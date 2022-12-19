using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpSlider : PlayerExpManager
{
    public GameObject other;
    public Slider expShow;

    private void Awake()
    {
      
    }
    // Start is called before the first frame update
    void Start()
    {
        expShow.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        expShow.value = (float)exp / maxExp;
    }
}
