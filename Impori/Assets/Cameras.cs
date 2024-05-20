using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject BossCam1;

    public static int state = 0;

    void Start()
    {
        MainCamera.SetActive(false);
        BossCam1.SetActive(true);
        BossCam1.SetActive(false);
        MainCamera.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (state == 0)
        {
            MainCamera.SetActive(true);
            BossCam1.SetActive(false);
        }
        if (state == 1)
        {
            MainCamera.SetActive(false);
            BossCam1.SetActive(true);
        }
    }
}
