using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Delivery : MonoBehaviour, IDropHandler
{
    //Carrega script dos pedidos
    [HideInInspector] public Requests requests;
    //carrega objeto do novo prato comprado
    public GameObject newDish3, newPan, newTimeScript;
    //Timer dos pedidos
    [HideInInspector] public TimerScript[] timerScript = new TimerScript[4];
    [HideInInspector] public GameObject[] timer = new GameObject[4];
    //Variaveis de pountuação
    public float xpPoints;
    [HideInInspector] public float totalXpPoints;
    public float points;
    public float lostPoints;
    [HideInInspector] public float totalPoints;
    //Variavel para verificar se foi entregue e altar a imagem para empty em seu respectivo prato
    [HideInInspector] public int delivered;
    //Textos dos pontos
    [HideInInspector] public Text pointsText;
    [HideInInspector] public Text totalPointsText;
    [HideInInspector] public Text finalMoneyText;
    [HideInInspector] public Text finalXpText;
    //Animação do texto
    [HideInInspector] public Animator anim;
    //Carrega script do manager para atualizar as compras
    [HideInInspector] public Manager manager;

    public GameObject[] stars;

    public float starPoints;

    //Verifica qual prato foi entregue e se estiver ativo nos pedidos atribui sua pontuação positiva se não aplica a negativa negativa
    public void OnDrop(PointerEventData eventData)
    {
        if (DragHandeler.itemBeginDragged.tag == "dish1")
        {
            delivered = 1;

            if (requests.request1.activeSelf)
            {
                requests.request1.SetActive(false);
                timer[0].SetActive(false);
                timerScript[0].timeLeft = timerScript[0].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //lostPoints = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish2")
        {
            delivered = 2;

            if (requests.request2.activeSelf)
            {
                requests.request2.SetActive(false);
                timer[1].SetActive(false);
                timerScript[1].timeLeft = timerScript[1].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish3")
        {
            delivered = 3;

            if (requests.request3.activeSelf)
            {
                requests.request3.SetActive(false);
                timer[2].SetActive(false);
                timerScript[2].timeLeft = timerScript[2].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish4")
        {
            delivered = 4;

            if (requests.request4.activeSelf)
            {
                requests.request4.SetActive(false);
                timer[3].SetActive(false);
                timerScript[3].timeLeft = timerScript[2].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish105")
        {
            delivered = 5;

            //points = -50f;
            pointsText.text = lostPoints.ToString();
            anim.Play("NegativeTextPoints");
            totalPoints += lostPoints;
            //points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish106")
        {
            delivered = 6;

            //points = -50f;
            pointsText.text = lostPoints.ToString();
            anim.Play("NegativeTextPoints");
            totalPoints += lostPoints;
            //points = 0f;
        }

        if (DragHandeler.itemBeginDragged.tag == "dish11")
        {
            delivered = 11;

            if (requests.request1.activeSelf)
            {
                requests.request1.SetActive(false);
                timer[0].SetActive(false);
                timerScript[0].timeLeft = timerScript[0].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish12")
        {
            delivered = 12;

            if (requests.request2.activeSelf)
            {
                requests.request2.SetActive(false);
                timer[1].SetActive(false);
                timerScript[1].timeLeft = timerScript[1].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish13")
        {
            delivered = 13;

            if (requests.request3.activeSelf)
            {
                requests.request3.SetActive(false);
                timer[2].SetActive(false);
                timerScript[2].timeLeft = timerScript[2].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish14")
        {
            delivered = 14;

            if (requests.request4.activeSelf)
            {
                requests.request4.SetActive(false);
                timer[3].SetActive(false);
                timerScript[3].timeLeft = timerScript[2].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish115")
        {
            delivered = 15;

            //points = -50f;
            pointsText.text = lostPoints.ToString();
            anim.Play("NegativeTextPoints");
            totalPoints += lostPoints;
            //points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish116")
        {
            delivered = 16;

            //points = -50f;
            pointsText.text = lostPoints.ToString();
            anim.Play("NegativeTextPoints");
            totalPoints += lostPoints;
            //points = 0f;
        }

        if (DragHandeler.itemBeginDragged.tag == "dish21")
        {
            delivered = 21;

            if (requests.request1.activeSelf)
            {
                requests.request1.SetActive(false);
                timer[0].SetActive(false);
                timerScript[0].timeLeft = timerScript[0].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish22")
        {
            delivered = 22;

            if (requests.request2.activeSelf)
            {
                requests.request2.SetActive(false);
                timer[1].SetActive(false);
                timerScript[1].timeLeft = timerScript[1].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish23")
        {
            delivered = 23;

            if (requests.request3.activeSelf)
            {
                requests.request3.SetActive(false);
                timer[2].SetActive(false);
                timerScript[2].timeLeft = timerScript[2].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish24")
        {
            delivered = 24;

            if (requests.request4.activeSelf)
            {
                requests.request4.SetActive(false);
                timer[3].SetActive(false);
                timerScript[3].timeLeft = timerScript[2].maxTime;
                //points = 200f;
                //xpPoints = 1000f;
                pointsText.text = ("+" + points.ToString());
                anim.Play("TextPoints");
                totalPoints += points;
                totalXpPoints += xpPoints;
                //points = 0f;
                //xpPoints = 0f;
            }
            else
            {
                //points = -50f;
                pointsText.text = lostPoints.ToString();
                anim.Play("NegativeTextPoints");
                totalPoints += lostPoints;
                //points = 0f;
            }
        }
        if (DragHandeler.itemBeginDragged.tag == "dish125")
        {
            delivered = 25;

            //points = -50f;
            pointsText.text = lostPoints.ToString();
            anim.Play("NegativeTextPoints");
            totalPoints += lostPoints;
            //points = 0f;
        }
        if (DragHandeler.itemBeginDragged.tag == "dish126")
        {
            delivered = 26;

            //points = -50f;
            pointsText.text = lostPoints.ToString();
            anim.Play("NegativeTextPoints");
            totalPoints += lostPoints;
            //points = 0f;
        }
    }
    //-Atualiza o texto dos pontos -Atualiza as compras. -Verifica quantidade de estrelas ganha
    void Update()
    {
        totalPointsText.text = totalPoints.ToString();
        finalMoneyText.text = ("  Money : + " + totalPoints).ToString();
        finalXpText.text =    ("  Xp    : + " + totalXpPoints).ToString();

        if (totalPoints < 0)
        {
            totalPoints = 0;
        }

        if (totalPoints >= starPoints)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(false);
            //Debug.Log(starPoints);

            if (totalPoints >= starPoints*1.5f)
            {
                stars[1].SetActive(true);
                stars[2].SetActive(false);

                if (totalPoints >= starPoints*1.75f)
                {
                    stars[2].SetActive(true);
                }
            }
        }

        if (manager.newDishes >= 1)
        {
            newDish3.SetActive(true);
        }
        if (manager.newPan >= 1)
        {
            newPan.SetActive(true);
            newTimeScript.SetActive(true);
        }
    }
}
