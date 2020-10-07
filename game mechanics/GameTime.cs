using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
 
public class GameTime : MonoBehaviour {
 
  // Set this in the inspector
  public GameObject TotalSeconds;
  public GameObject onex;
  public GameObject tenx;
  public GameObject hundredx;
  public GameObject GameClock;


  private float timeSpeed = 1f;


  public int CurrentSeconds;

  private float tickTimer;
  

    private int days;
    private int hours;
    private int minutes;
    private int seconds;

    private string hoursString;
    private string minutesString;
    private string secondsString;


    void Start () {


    }

    void Update () {
        tickTimer += Time.deltaTime;

    if (Input.GetButtonDown("1x Speed")){
            timeSpeed = 1f;
            onex.GetComponent<Image>().color = new Color32(60,250,20,255);
            tenx.GetComponent<Image>().color = new Color32(255,250,255,255);
            hundredx.GetComponent<Image>().color = new Color32(255,250,255,255);
    }
     if (Input.GetButtonDown("10x Speed")){
            timeSpeed = .1f;
            onex.GetComponent<Image>().color = new Color32(255,250,255,255);
            tenx.GetComponent<Image>().color = new Color32(60,250,20,255);
            hundredx.GetComponent<Image>().color = new Color32(255,250,255,255);

    }
     if (Input.GetButtonDown("100x Speed")){
            timeSpeed = .01f;
            onex.GetComponent<Image>().color = new Color32(255,250,255,255);
            tenx.GetComponent<Image>().color = new Color32(255,250,255,255);
            hundredx.GetComponent<Image>().color = new Color32(60,250,20,255);
    }

        if (tickTimer >= timeSpeed) {
            tickTimer -= timeSpeed;
            ++CurrentSeconds;
            days = CurrentSeconds / 86400;
            hours = (CurrentSeconds % 86400) / 3600;
            minutes = (CurrentSeconds % 3600) / 60;
            seconds = (CurrentSeconds % 3600 ) % 60;
            hoursString = hours.ToString("00");
            minutesString = minutes.ToString("00");
            secondsString = seconds.ToString("00");
            TotalSeconds.GetComponent<Text>().text ="Total Seconds: " + CurrentSeconds;
            GameClock.GetComponent<Text>().text = "Day: " + days + " Time: " + hoursString + ":" + minutesString + ":" + secondsString;

        }
    }
}
 