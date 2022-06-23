using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCooldown : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public int secondsleft = 30;
    public bool takingAway = false;

    void Start()
    {
        secondsleft = 30;
        SetCountText();
    }

    void SetCountText()
    {
        textDisplay.text = "00:" + secondsleft.ToString();
    }
    // Start is called before the first frame update
    void Update()
    {
        if(takingAway == false && secondsleft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(secondsleft);
        secondsleft -= 1;
        SetCountText();
        takingAway = false;
    }
}
