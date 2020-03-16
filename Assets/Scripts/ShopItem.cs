﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Shop Item")]
public class ShopItem : ScriptableObject
{
    public string itemName;
    public Sprite sprite;
    public float cost;
    public Color backgroundColor;
}
