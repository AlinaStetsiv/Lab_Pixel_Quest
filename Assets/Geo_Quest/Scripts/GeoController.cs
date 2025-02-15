using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string GlobalVar = "Hello";
    int value = 3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string LocalVar = "Word";
        Debug.Log(GlobalVar + " "+ LocalVar);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(value);
        value++;
    }
}
