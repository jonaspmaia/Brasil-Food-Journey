using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float money;
    public float xp;
    public int newDishes;
    public int newPan;
    public int xpLevel;

    public PlayerData(Manager manager)
    {
        money = manager.moneyPoints;
        xp = manager.xp;
        newDishes = manager.newDishes;
        newPan = manager.newPan;
        xpLevel = manager.xpLevel;
    }
}
