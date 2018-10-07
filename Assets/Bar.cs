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
        if (FoodGenerator.state != FoodGenerator.State.Play) return;

        food -= (5 + Level.level / 5) * Time.deltaTime;
        cooldown.fillAmount = (float)(food / goal);

        if (food > 100 || Bar.food < 0) FoodGenerator.state = FoodGenerator.State.Die;
    }
}
