using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public float timeStart;

    public Text textBox;

    public bool countXp;

    public GameObject gameoverMenu;
    public Delivery delivery;
    public Manager manager;

    void Start()
    {
        textBox.text = timeStart.ToString();
        countXp = true;
    }

    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

        if (timeStart <= 0)
        {
            if (countXp == true)
            {
                manager.moneyPoints += delivery.totalPoints;
                manager.xp += delivery.totalXpPoints;
                countXp = false;
            }
            
            SaveSystem.SavePlayer(manager);
            gameoverMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
