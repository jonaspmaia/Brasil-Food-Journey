using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class pan : MonoBehaviour, IDropHandler
{
    public GameObject emptyPan, panSauce, cookingPan, panBurned;
    public GameObject timer, timer2;

    public TimerScript timerScript;
    public TimerScript timerScript2;

    public dish[] dishes;

    public trash trash;

    public int steps;

    public bool empty;

    public void OnDrop(PointerEventData eventData)
    {
        if (DragHandeler.itemBeginDragged.tag == "sauce" && emptyPan.activeSelf)
        {
            emptyPan.SetActive(false);
            cookingPan.SetActive(true);
            timer.SetActive(true);
        }
    }

    void Start()
    {
        empty = false;
    }

    void Update()
    {
        if (timer.activeSelf && steps == 0)
        {
            if (timerScript.timeLeft <= 0)
            {
                cookingPan.SetActive(false);
                panSauce.SetActive(true);
                timer2.SetActive(true);
                timerScript.timeLeft = timerScript.maxTime;
                steps = 1;
            }
        }
        if (timer2.activeSelf)
        {
            if (timerScript2.timeLeft <= 0 && timerScript2.enabled == true)
            {
                panSauce.SetActive(false);
                panBurned.SetActive(true);
                timer2.SetActive(false);
            }
        }

        if (empty == true)
        {
            panBurned.SetActive(false);
            panSauce.SetActive(false);
            timer2.SetActive(false);
            timer.SetActive(false);
            emptyPan.SetActive(true);
            timerScript.timeLeft = timerScript.maxTime;
            timerScript2.timeLeft = timerScript.maxTime;
            steps = 0;
            empty = false;
        }

        /*if (dishes[0].pan)
        {
            panSauce.SetActive(false);
            timer2.SetActive(false);
            timer.SetActive(false);
            emptyPan.SetActive(true);
            dishes[0].pan = false;
            timerScript.timeLeft = timerScript.maxTime;
            timerScript2.timeLeft = timerScript.maxTime;
            steps = 0;
        }
        if (dishes[1].pan)
        {
            panSauce.SetActive(false);
            timer2.SetActive(false);
            timer.SetActive(false);
            emptyPan.SetActive(true);
            dishes[1].pan = false;
            timerScript.timeLeft = timerScript.maxTime;
            timerScript2.timeLeft = timerScript.maxTime;
            steps = 0;
        }
        if (dishes[2].pan)
        {
            panSauce.SetActive(false);
            timer2.SetActive(false);
            timer.SetActive(false);
            emptyPan.SetActive(true);
            dishes[2].pan = false;
            timerScript.timeLeft = timerScript.maxTime;
            timerScript2.timeLeft = timerScript.maxTime;
            steps = 0;
        }*/
    }
}
