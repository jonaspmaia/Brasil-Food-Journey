using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Requests : MonoBehaviour
{
    public GameObject request1, request2, request3, request4;

    private static int requestNumber;

    [SerializeField] private Text counterTx;

    private int counter = 1;

    void Start()
    {
        StartCoroutine(CounterStart());
    }

    private IEnumerator CounterStart()
    {
        do
        {
            counterTx.text = counter.ToString();
            yield return new WaitForSeconds(1f);
            counter++;
        } while (counter <= 3);

        counterTx.gameObject.SetActive(false);

        StartCoroutine(ShuffleNumber(1, 5));
    }

    private IEnumerator ShuffleNumber(int min, int max)
    {
        requestNumber = Random.Range(min, max);
        yield return new WaitForSeconds(5f);
        StartCoroutine(ShuffleNumber(1, 5));
    }

    void Update()
    {

    }

    public int GetRequestNumber()
    {
        return requestNumber;
    }
    public void SetRequestNumber(int newNumber)
    {
        requestNumber = newNumber;
    }
}
