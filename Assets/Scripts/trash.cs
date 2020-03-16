using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class trash : MonoBehaviour, IDropHandler
{
    public int trashed;
    public float points;

    public Animator anim;
    public Animator PointsAnim;

    public Delivery deliveryPoints;

    public Text trashPointsText;

    public pan[] pans;

    public void OnDrop(PointerEventData eventData)
    {
        if (DragHandeler.itemBeginDragged.tag == "dish1")
        {
            trashed = 1;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;

        }
        if (DragHandeler.itemBeginDragged.tag == "dish2")
        {
            trashed = 2;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish3")
        {
            trashed = 3;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish4")
        {
            trashed = 4;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish105")
        {
            trashed = 5;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish106")
        {
            trashed = 6;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }



        if (DragHandeler.itemBeginDragged.tag == "dish11")
        {
            trashed = 11;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish12")
        {
            trashed = 12;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish13")
        {
            trashed = 13;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish14")
        {
            trashed = 14;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish115")
        {
            trashed = 15;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish116")
        {
            trashed = 16;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }



        if (DragHandeler.itemBeginDragged.tag == "burned")
        {
            //trashed = 100;
            pans[0].empty = true;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }

        if (DragHandeler.itemBeginDragged.tag == "burned2")
        {
            //trashed = 200;
            pans[1].empty = true;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }



        if (DragHandeler.itemBeginDragged.tag == "dish21")
        {
            trashed = 21;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish22")
        {
            trashed = 22;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish23")
        {
            trashed = 23;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish24")
        {
            trashed = 24;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish125")
        {
            trashed = 25;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish126")
        {
            trashed = 26;
            anim.Play("BasketAnimation");
            points = -100f;
            trashPointsText.text = points.ToString();
            PointsAnim.Play("NegativeTextPoints");
            deliveryPoints.totalPoints += points;
            points = 0f;
        }

    }
}
