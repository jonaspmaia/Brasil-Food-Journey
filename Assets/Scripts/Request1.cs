using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request1 : MonoBehaviour
{
    public GameObject timer;

    public TimerScript timeScript;

    public Delivery delivery;

    public bool noDelivery;

    Requests requests;

    private void Start()
    {
        requests = FindObjectOfType<Requests>();
        noDelivery = true;
    }

    void Update()
    {
        if (requests.GetRequestNumber() == 1 && requests.request1.activeSelf == false)
        {
            noDelivery = false;
            requests.request1.SetActive(true);
            timer.SetActive(true);
            requests.SetRequestNumber(0);
        }

        if (timeScript.timeLeft <= 0)
        {
            if (noDelivery == false)
            {
                delivery.totalPoints += -100f;
                noDelivery = true;
            }
            timer.SetActive(false);
            requests.request1.SetActive(false);
            timeScript.timeLeft = timeScript.maxTime;
        }
    }
}
