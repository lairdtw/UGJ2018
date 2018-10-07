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
        if (FoodGenerator.state != FoodGenerator.State.Play) return;

        Vector3 v= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (v.x > 3) v.x = 3;
        if (v.x < -3) v.x = -3;
        if (v.y > 2.5) v.y = 2.5f;
        if (v.y < -2.5) v.y = -2.5f;

        transform.position = new Vector3(v.x,v.y,0);
    }
}
