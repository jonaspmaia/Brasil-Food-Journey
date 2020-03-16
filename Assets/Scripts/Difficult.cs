using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficult : MonoBehaviour
{
    public int easyGameTime, easyRequestsTime, easyPoints, easyLostPoints, easyXpPoints, easyTrashPoints,easyStarPoints, midGameTime, midRequestsTime, midPoints, midLostPoints, midXpPoints, midTrashPoints, midStarPoints, hardGameTime, hardRquestsTime, hardPoints, hardLostPoints, hardXpPoints, hardTrashPoints, hardStarPoints;
    public TimerScript gameTimer, requestTimer1, requestTimer2, requestTimer3, requestTimer4;
    public GameTime gameTime;
    public Delivery delivery;
    public trash trash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void EasyMode()
    {
        Time.timeScale = 1f;
        gameTime.timeStart = easyGameTime;
        gameTimer.maxTime = easyGameTime;
        gameTimer.timeLeft = easyGameTime;

        requestTimer1.maxTime = easyRequestsTime;
        requestTimer1.timeLeft = easyRequestsTime;
        requestTimer2.maxTime = easyRequestsTime;
        requestTimer2.timeLeft = easyRequestsTime;
        requestTimer3.maxTime = easyRequestsTime;
        requestTimer3.timeLeft = easyRequestsTime;
        requestTimer4.maxTime = easyRequestsTime;
        requestTimer4.timeLeft = easyRequestsTime;

        delivery.points = easyPoints;
        delivery.lostPoints = easyLostPoints;
        delivery.xpPoints = easyXpPoints;

        trash.points = easyTrashPoints;

        delivery.starPoints = easyStarPoints;

    }

    public void MidMode()
    {
        Time.timeScale = 1f;
        gameTime.timeStart = midGameTime;
        gameTimer.maxTime = midGameTime;
        gameTimer.timeLeft = midGameTime;

        requestTimer1.maxTime = midRequestsTime;
        requestTimer1.timeLeft = midRequestsTime;
        requestTimer2.maxTime = midRequestsTime;
        requestTimer2.timeLeft = midRequestsTime;
        requestTimer3.maxTime = midRequestsTime;
        requestTimer3.timeLeft = midRequestsTime;
        requestTimer4.maxTime = midRequestsTime;
        requestTimer4.timeLeft = midRequestsTime;

        delivery.points = midPoints;
        delivery.lostPoints = midLostPoints;
        delivery.xpPoints = midXpPoints;

        trash.points = midTrashPoints;

        delivery.starPoints = midStarPoints;
    }

    public void HardMode()
    {
        Time.timeScale = 1f;
        gameTime.timeStart = hardGameTime;
        gameTimer.maxTime = hardGameTime;
        gameTimer.timeLeft = hardGameTime;

        requestTimer1.maxTime = hardRquestsTime;
        requestTimer1.timeLeft = hardRquestsTime;
        requestTimer2.maxTime = hardRquestsTime;
        requestTimer2.timeLeft = hardRquestsTime;
        requestTimer3.maxTime = hardRquestsTime;
        requestTimer3.timeLeft = hardRquestsTime;
        requestTimer4.maxTime = hardRquestsTime;
        requestTimer4.timeLeft = hardRquestsTime;

        delivery.points = hardPoints;
        delivery.lostPoints = hardLostPoints;
        delivery.xpPoints = hardXpPoints;

        trash.points = hardTrashPoints;

        delivery.starPoints = hardStarPoints;
    }
}
