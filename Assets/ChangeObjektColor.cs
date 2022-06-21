using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjektColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColorBlack()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }
    
    public void SetColorWhite()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
