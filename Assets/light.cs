using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class light : MonoBehaviour
{
   
    private GameObject Idle;
    public GameObject Mountain;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;

    // Start is called before the first frame update
    void Start()
    {
        Idle = GameObject.Find("Idle");
        obj9.SetActive(false);
        obj10.SetActive(false);
        obj11.SetActive(false);
        obj12.SetActive(false);
        obj13.SetActive(false);
        obj14.SetActive(false);
        obj15.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(Mountain.transform);
        Vector3 posi = this.transform.position;
        Vector3 IdlePos = Idle.transform.position;
        // Debug.Log(IdlePos);
        float dis = Vector3.Distance(posi,IdlePos);

        if(dis < 10)
        {
        transform.position += transform.TransformDirection(Vector3.forward)*10f*Time.deltaTime;
        }

        // Debug.Log(dis);
        // Debug.Log("aaa");
        // transform.position += transform.TransformDirection(Vector3.forward)*10f*Time.deltaTime;
    }
}
