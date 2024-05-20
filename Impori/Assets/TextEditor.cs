using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditor : MonoBehaviour
{
    //public static Text canvasText = gameObject;
    public static int state = 1;
    public static int power = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Power: 1";
    }

    public void Change()
    {
        power += Random.Range(1, 7); 
        gameObject.GetComponent<Text>().text = "Power: " + power;
    }
}
