using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public static double food = 100, goal = 100;
    public Image cooldown;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        food -= 5 * Time.deltaTime;
        food = food > 100 ? 100 : food;
        cooldown.fillAmount = (float)(food / goal);
        Debug.Log(food);
        Debug.Log(cooldown.fillAmount);
    }
}
