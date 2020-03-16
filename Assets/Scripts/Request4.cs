using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request4 : MonoBehaviour
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
        if (requests.GetRequestNumber() == 4 && requests.request4.activeSelf == false)
        {
            noDelivery = false;
            requests.request4.SetActive(true);
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
            requests.request4.SetActive(false);
            timeScript.timeLeft = timeScript.maxTime;
        }
    }
}
