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

        transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y,0);
    }
}
