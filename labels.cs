using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGUI()
    {
        GUI.Label(new Rect(0,0,80,20),"Hello World");
    }
}
