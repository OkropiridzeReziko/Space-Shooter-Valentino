using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 20f;
     public UIManager manager;

    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("F0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            countdownText.text = currentTime.ToString("F0");
            manager.GoToPage(2);
        }
    }
}
