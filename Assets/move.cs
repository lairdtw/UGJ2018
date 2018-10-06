using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.position += new Vector3(-0.1f, 0, 0) ;
        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.position += new Vector3(0.1f, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.position += new Vector3(0, 0, 0.1f);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.position += new Vector3(0, 0, -0.1f);
        if (Input.GetKey(KeyCode.Space))
            this.transform.position += new Vector3(0, 0.1f, 0);
        if (Input.GetKey(KeyCode.LeftShift))
            this.transform.position += new Vector3(0, -0.1f, 0);
    }
}
