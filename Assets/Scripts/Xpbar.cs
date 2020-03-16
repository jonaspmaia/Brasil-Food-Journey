using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xpbar : MonoBehaviour
{
    Image timeBar;

    public float maxBar;

    [HideInInspector] public float barLeft;

    public Manager manager;

    private void Awake()
    {
        barLeft = 0;
    }

    void Start()
    {
        timeBar = GetComponent<Image>();
        barLeft = 0;
    }

    void Update()
    {
        barLeft = manager.xp;
        timeBar.fillAmount = barLeft / maxBar;

        /*if (barLeft == maxBar)
        {
            barLeft = 0;
        }*/
    }
}
