using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image timeBar;

    public float maxTime;

    [HideInInspector] public float timeLeft;

    private void Awake()
    {
        timeLeft = maxTime;
    }

    void Start()
    {
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;
        }
    }
}
