using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Manager manager;

    [Header("List of items sold")]
    [SerializeField] private ShopItem[] shopItem;

    [Header("references")]
    [SerializeField] private Transform shopPanel;
    [SerializeField] private GameObject shopItemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        PopulateShop();  
    }

    private void PopulateShop()
    {
        for (int i = 0; i < shopItem.Length; i++)
        {
            ShopItem si = shopItem[i];
            GameObject itemObject = Instantiate(shopItemPrefab, shopPanel);

            itemObject.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(si));

            itemObject.GetComponent<Image>().color = si.backgroundColor;
            itemObject.transform.GetChild(0).GetComponent<Image>().sprite = si.sprite;
            itemObject.transform.GetChild(1).GetComponent<Text>().text = si.itemName;
            itemObject.transform.GetChild(2).GetComponent<Text>().text = si.cost.ToString();
        }
    }

    private void OnButtonClick(ShopItem item)
    {
        //Debug.Log(item.name);
        if (manager.moneyPoints >= item.cost)
        {
            if (item.name == "Dish")
            {
                manager.moneyPoints -= item.cost;
                manager.newDishes += 1;
            }
            if (item.name == "Pan")
            {
                manager.moneyPoints -= item.cost;
                manager.newPan += 1;
            }

        }
        //Destroy(item);
        SaveSystem.SavePlayer(manager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
