using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputF : MonoBehaviour
{
     private int Hello;

    public GameObject obj;
    public GameObject obj2;
    
    void Start()
    {
        obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            obj.SetActive(false);
            obj2.SetActive(true);
        }
    }
}
