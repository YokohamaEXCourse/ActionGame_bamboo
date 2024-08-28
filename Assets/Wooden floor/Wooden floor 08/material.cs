using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class material : MonoBehaviour
{
    [SerializeField]
    Material _materia1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.1f;
        float centerSize = 0.5f;
        float deltaSize = 0.5f;
        float alpha = centerSize + Mathf.Cos(Time.time * Mathf.PI * 2.0f * speed) * deltaSize;
        _materia1.SetColor("_Color", new Color(1.0f,1.0f,1.0f,alpha));
    }
}
