using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCooldown : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsleft = 30;
    public bool takingAway = false;

    void Start()
    {
        textDisplay.GetComponent <TMPro.TextMeshProUGUI>().text = "00:" + secondsleft;
    }
    // Start is called before the first frame update
    void Update()
    {
        if(takingAway == false&& secondsleft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(secondsleft);
        secondsleft -= 1;
        textDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "00:" + secondsleft;
        takingAway = false;
    }
}
