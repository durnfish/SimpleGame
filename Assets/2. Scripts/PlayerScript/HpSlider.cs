using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSlider : MonoBehaviour
{
    public static HpSlider hpSlider;

    public GameObject other;
    int currentHp;
    int maxHp;

    public Slider hpshow;

    void Awake()
    {
        currentHp = other.GetComponent<HpManager>().hp;
        maxHp = other.GetComponent<HpManager>().maxHp;

        DontDestroyOnLoad(gameObject);
        if (hpSlider == null)
        {
            hpSlider = this;
        }
        else if (hpSlider != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        hpshow.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        //currentHp = GetComponent<PlayerHpManager>().hp;
        //maxHp = GetComponent<PlayerHpManager>().maxHp;
        hpshow.value = (float)currentHp/ maxHp;
    }
}
