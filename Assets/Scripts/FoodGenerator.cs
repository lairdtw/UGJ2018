using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    float AddRate = 1.0f;
    float timer = 0;

    int randomIndex;

    int r1;

    // The target marker.
    //public GameObject Playground;

    public List<GameObject> AllFoods;

    public float moveSpeed = 2f;

    public static List<GameObject> FoodDrop = new List<GameObject>();

    float[] foodPos = new float[] { -2.4f,-1.2f,0.0f,1.2f,2.4f};

    void Awake()
    {
        //        GameLogic.GetInstance().GeneratorMediator.Regist_FoodGenerator(this);
    }

    void Start()
    {
        Init();
    }

    public void Init()
    {

        //初始位置
        AddFood();

        // The step size is equal to speed times frame time.
        //float Speed = DropSpeed * Time.deltaTime;

        // Move our position a step closer to the target.
        //Food.transform.position = Vector3.MoveTowards(Food.transform.position, Playground.transform.position, Speed);




    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < FoodDrop.Count; i++)
        {
            FoodDrop[i].transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

            if(FoodDrop[i].transform.position.y<-3){
                Destroy(FoodDrop[i]);
                FoodDrop.RemoveAt(i);
                i--;
            }
        }

        if (timer < AddRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            AddFood();
            timer = 0;
        }

    }

    //For Timer
    public void GenerateAccordingTime()
    {

        Init();
    }


    void AddFood()
    {
        int rShow = Random.Range(1, 6);

        List<int> strPos = new List<int>();
        for (int i = 0; i < rShow; i++)
        {
            strPos.Add(i);
        }

        for (int i = 0; i < rShow; i++)
        {
            randomIndex = Random.Range(0, AllFoods.Count);

            r1 = strPos[Random.Range(0, strPos.Count)];
            strPos.Remove(r1);

            GameObject f = Instantiate(AllFoods[randomIndex]) as GameObject;
            f.transform.position = new Vector3(foodPos[r1], 3.2f, 0);
            FoodDrop.Add(f);
        }
    }
}

