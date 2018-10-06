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
        int x = 1, z = 1;
        float d = 0.1f;
        float f = 0.7071f * d;
        float[,] dir = new float[,] {
            {-f,0,f},
            {-d,0,d},
            {-f,0,f}
        };

        if (Input.GetKey(KeyCode.UpArrow))
            z++;
        if (Input.GetKey(KeyCode.DownArrow))
            z--;
        if (Input.GetKey(KeyCode.RightArrow))
            x++;
        if (Input.GetKey(KeyCode.LeftArrow))
            x--;

        Vector3 v = transform.position;
        transform.position += new Vector3(dir[z, x], dir[x, z], 0);

        if (v.x > 3)
            transform.position += new Vector3(3 - v.x, 0);
        if (v.x < -3)
            transform.position += new Vector3(-3 - v.x, 0);
        if (v.z > 2.5)
            transform.position += new Vector3(0, 2.5f - v.z, 0);
        if (v.z < -2.5)
            transform.position += new Vector3(0, - 2.5f - v.z, 0);
    }
}
