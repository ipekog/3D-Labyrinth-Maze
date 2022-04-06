using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private bool finnished = false;
    private bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished)
        {
            Time.timeScale = 0;
            return;
        }

        if (started)
        {
            startTime = startTime + Time.deltaTime;

            string minutes = ((int) startTime / 60).ToString();
            string seconds = (startTime % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }
        
    }

    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.black;
    }

    public void Started()
    {
        started = true;
    }
}
