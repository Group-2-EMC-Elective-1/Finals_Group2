using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Clock : MonoBehaviour
{
    private int hour_ = 0;
    private int minute_ = 0;
    private int seconds_ = 0;

    private Text textClock;
    private float delta_Time;
    private bool stop_clock = false;

    public static Clock instance;

    private void Awake()
    {
        if (instance)
            Destroy(instance);

        instance = this;

        textClock = GetComponent<Text>();
        delta_Time = 0;
    }
    void Start()
    {
        stop_clock = false;
    }

    void Update()
    {
        if (stop_clock == false)
        {
            delta_Time += Time.deltaTime;
            TimeSpan span = TimeSpan.FromSeconds(delta_Time);
            string hour = LeadingZero(span.Hours);
            string minute = LeadingZero(span.Minutes);
            string seconds = LeadingZero(span.Seconds);

            textClock.text = hour + ":" + minute + ":" + seconds;
        }
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }

    public void OnGameOver()
    {
        stop_clock = true;
    }

    private void OnEnable()
    {
        GameEvent.OnGameOver += OnGameOver;
    }

    private void OnDisable()
    {
        GameEvent.OnGameOver -= OnGameOver;
    }

    public Text GetCurrentTimeText()
    {
        return textClock;
    }
}
