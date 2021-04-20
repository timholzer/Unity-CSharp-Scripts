using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RayCastColorChange : MonoBehaviour
{


    public GameObject exit;
    public static string hitName;
    public static int exitTimer;
    public GameObject exitStatusBar;
    public GameObject exitText;
    public GameObject exitStatusWhole;
    public static float offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)){

            }
        if (hit.collider == null){
                hitName = "no target";
            }
        if (hitName != "exit"){
            exitTimer = 0;
            Debug.Log(exitTimer);
            exitStatusWhole.SetActive(false);
        }
        if (hit.collider != null){
               hitName = hit.collider.ToString();
               //removes  (UnityEngine.BoxCollider) from the returned string so that just the Gameobject name needs to be encoded
               hitName = hitName.Substring(0, hitName.Length-26);
               Debug.Log(hitName + "hitted");


//if you want to have a gameobject named exit to look at to exit after a few seconds.
        if (hitName == "exit"){
            exitTimer ++;
            Debug.Log(exitTimer);
            exit.transform.Rotate(-.25f,0,0);
            exitText.GetComponentInChildren<Text>().text = "Exiting " + Math.Ceiling(exitTimer/8f) + "/100";
            offset = -200 + (exitTimer/4);
            exitStatusBar.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal , (offset + 200));
            exitStatusBar.GetComponent<RectTransform>().anchoredPosition = new Vector3(offset/2, -110, 0);
            exitStatusWhole.SetActive(true);
            if (exitTimer >= 800) {
                Debug.Log("exiting");
    #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
     #else
         Application.Quit();
     #endif
            }
        }
        }
    }
}