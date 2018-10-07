using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    float AddRate = 1.0f;
    float timer = 0;
    public enum State { Start, Play, Die, Next };
    public static State state;

    int randomIndex;

    int r1;

    // The target marker.
    //public GameObject Playground;

    public List<GameObject> AllFoods;

    public static List<GameObject> FoodDrop = new List<GameObject>();

    float[] foodPos = new float[] { -2.4f, -1.2f, 0, 1.2f, 2.4f };

    public GameObject bg;
    GameObject b1, b2;
    float d = 9.98f;

    void Awake()
    {
        //        GameLogic.GetInstance().GeneratorMediator.Regist_FoodGenerator(this);
    }

    void Start()
    {
        state = State.Start;
        //Init();

        b1 = Instantiate(bg) as GameObject;
        b2 = Instantiate(bg) as GameObject;

        b1.transform.position = new Vector3(0, 0, 0);
        b2.transform.position = new Vector3(0, d, 0);
    }

    public void Init()
    {
        Timer.timer = 15;
        foreach (GameObject f in FoodDrop) Destroy(f);
        FoodDrop.Clear();
        AddFood();
        state = State.Play;
        Bar.food = 50;

        GameObject.Find("Player").transform.position = new Vector3(0, -2, 0);
    }

    void Menu()
    {
        if (!Input.GetMouseButton(0)) return;

        if (state == State.Start || state == State.Die) Init();

        if (state == State.Next)
        {
            Level.level++;
            Init();

        }
    }

    // Update is called once per frame
    void Update()
    {
        Menu();

        if (state != State.Play) return;

        for (int i = 0; i < FoodDrop.Count; i++)
        {
            FoodDrop[i].transform.Translate(Vector3.down * (3+Level.level/5) * Time.deltaTime);

            if (FoodDrop[i].transform.position.y < -3)
            {
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
            AddRate = Random.Range(1,3);
            timer = 0;
        }

        b1.transform.position += new Vector3(0, -0.02f, 0);
        if (b1.transform.position.y < -d) b1.transform.position += new Vector3(0, 2*d, 0);

        b2.transform.position += new Vector3(0, -0.02f, 0);
        if (b2.transform.position.y < -d) b2.transform.position += new Vector3(0, 2*d, 0);
    }

    void AddFood()
    {
        //固定
        int rShow = Random.Range(1, 6);

        List<int> strPos = new List<int>();
        for (int i = 0; i < 5; i++)
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

