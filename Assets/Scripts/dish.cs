using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dish : MonoBehaviour, IDropHandler
{
    public GameObject[] dishes;
    //Carrega os objetos dos pratos
    public GameObject emptyDish, dish1, dish2, dish3, dish4, dish5, dish6;
    //Carrega script do lixo
    public trash trash;
    //Carrega script do Delivery
    public Delivery delivery;
    //Carrega os objetos da panela
    public pan[] pans;
    //variavel para verificar quantidade de filhos
    int childs;
    //Verifica qual ingrediente foi colocado no prato e ativa e desativa respectivas imagens
    public void OnDrop(PointerEventData eventData)
    {
        if (emptyDish.activeSelf)
        {
            if (DragHandeler.itemBeginDragged)
            {
                if (DragHandeler.itemBeginDragged.tag == "base")
                {
                    emptyDish.SetActive(false);
                    dish5.SetActive(true);
                }
            }
            if (PanDragHandeler.itemBeginDragged)
            {
                if (PanDragHandeler.itemBeginDragged.tag == "pansauce")
                {
                    emptyDish.SetActive(false);
                    dish6.SetActive(true);
                    pans[0].empty = true;
                }
            }
            if (PanDragHandeler.itemBeginDragged)
            {
                if (PanDragHandeler.itemBeginDragged.tag == "PanSauce2")
                {
                    emptyDish.SetActive(false);
                    dish6.SetActive(true);
                    pans[1].empty = true;
                }
            }
        }
        if (dish5.activeSelf)
        {
            if (PanDragHandeler.itemBeginDragged)
            {
                if (PanDragHandeler.itemBeginDragged.tag == "pansauce")
                {
                    dish5.SetActive(false);
                    dish1.SetActive(true);
                    pans[0].empty = true;
                }
            }
            if (PanDragHandeler.itemBeginDragged)
            {
                if (PanDragHandeler.itemBeginDragged.tag == "PanSauce2")
                {
                    dish5.SetActive(false);
                    dish1.SetActive(true);
                    pans[1].empty = true;
                }
            }
        }
        if (dish6.activeSelf)
        {
            if (DragHandeler.itemBeginDragged.tag == "base")
            {
                dish6.SetActive(false);
                dish1.SetActive(true);
            }
        }
        if (dish1.activeSelf)
        {
            if (DragHandeler.itemBeginDragged.tag == "item1")
            {
                dish1.SetActive(false);
                dish2.SetActive(true);
            }
            if (DragHandeler.itemBeginDragged.tag == "item2")
            {
                dish1.SetActive(false);
                dish3.SetActive(true);
            }
        }
        if (dish2.activeSelf)
        {
            if (DragHandeler.itemBeginDragged.tag == "item2")
            {
                dish2.SetActive(false);
                dish4.SetActive(true);
            }
        }
        if (dish3.activeSelf)
        {
            if (DragHandeler.itemBeginDragged.tag == "item1")
            {
                dish3.SetActive(false);
                dish4.SetActive(true);
            }
        }
    }
    //Verica se não tem pratos ativos e ativa o Prato vazio
    public void Empty()
    {
        bool childActive = false;

        for (int i = 0; i < childs; i++)
        {
            if (transform.GetChild(i).gameObject.activeSelf)
            {
                childActive = true;
            }
        }

        if (!childActive)
        {
            emptyDish.SetActive(true);
        }
    }
    //Verifica quantidade filhos
    void Start()
    {
        childs = transform.childCount;

    }
    //Recebe variaveis do lixo e do delivery para verificar qual prato foi dropado e zerar sua imagem e ativar o prato vazio
    void Update()
    {
        if (trash.trashed == 1)
        {
            dishes[0].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 2)
        {
            dishes[1].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 3)
        {
            dishes[2].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 4)
        {
            dishes[3].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 5)
        {
            dishes[4].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 6)
        {
            dishes[5].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 11)
        {
            dishes[6].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 12)
        {
            dishes[7].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 13)
        {
            dishes[8].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 14)
        {
            dishes[9].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 15)
        {
            dishes[10].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 16)
        {
            dishes[11].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 21)
        {
            dishes[12].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 22)
        {
            dishes[13].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 23)
        {
            dishes[14].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 24)
        {
            dishes[15].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 25)
        {
            dishes[16].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 26)
        {
            dishes[17].SetActive(false);
            trash.trashed = 0;
        }
        if (trash.trashed == 0)
        {
            Empty();
        }


        if (delivery.delivered == 1)
        {
            dishes[0].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 2)
        {
            dishes[1].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 3)
        {
            dishes[2].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 4)
        {
            dishes[3].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 5)
        {
            dishes[4].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 6)
        {
            dishes[5].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 11)
        {
            dishes[6].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 12)
        {
            dishes[7].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 13)
        {
            dishes[8].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 14)
        {
            dishes[9].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 15)
        {
            dishes[10].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 16)
        {
            dishes[11].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 21)
        {
            dishes[12].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 22)
        {
            dishes[13].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 23)
        {
            dishes[14].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 24)
        {
            dishes[15].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 25)
        {
            dishes[16].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 26)
        {
            dishes[17].SetActive(false);
            delivery.delivered = 0;
        }
        if (delivery.delivered == 0)
        {
            Empty();
        }
    }
}
