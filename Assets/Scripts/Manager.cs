using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public float moneyPoints;
    public float xp;
    public int xpLevel;
    public int newDishes;
    public int newPan;

    public Text moneyText;
    public Text xpNumberText;
    public GameObject levelUp;

    public void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        moneyPoints = data.money;
        xp = data.xp;
        xpLevel = data.xpLevel;
        newDishes = data.newDishes;
        newPan = data.newPan;
        levelUp.SetActive(false);
    }

    public void Update()
    {
        moneyText.text = moneyPoints.ToString();
        xpNumberText.text = xpLevel.ToString();

        if (xp >= 20000)
        {
            xpLevel = +1;
            xp += -20000;
            levelUp.SetActive(true);
        }
        
    }
}
