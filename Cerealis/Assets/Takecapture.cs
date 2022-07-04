using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takecapture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScreenCapture.CaptureScreenshot("ma capture");
        Debug.Log("its done");
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
