using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public int m_targetCounter;
    void Start()
    {
        TargetInstanse();
    }

    // Update is called once per frame
    void Update()
    {
        /*float x = Random.Range(Screen.width * 0.1f, Screen.width * 0.9f);
        float y = Random.Range(Screen.height * 0.1f, Screen.height * 0.9f);
        Vector2 screenPoint = new Vector2(x, y);*/

    }
    void TargetInstanse()
    {
        float x = Screen.width / 2;
        float y = Screen.height / 2;

        Vector2 screenPoint = new Vector2(5, y);
        Vector3 position = Camera.main.ScreenToWorldPoint(screenPoint);
        position.z = 0;



        //float x = Random.Range(-10.0f, 10.0f);
        //float y = Random.Range(-5f, 5f);
        //float z = Random.Range(0.0f, 5.0f);

        for (int i = 0; i < 5; i++)
        {
            Instantiate(target, position, Quaternion.identity);
            position = new Vector3(1, 0, 0);
        }


    }
}
