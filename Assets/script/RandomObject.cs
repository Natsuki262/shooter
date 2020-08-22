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
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(Screen.width * 0.1f, Screen.width * 0.9f);
        float y = Random.Range(Screen.height * 0.1f, Screen.height * 0.9f);
        Vector2 screenPoint = new Vector2(x, y);
        Vector3 position = Camera.main.ScreenToWorldPoint(screenPoint);
        position.z = 0;



        //float x = Random.Range(-10.0f, 10.0f);
        //float y = Random.Range(-5f, 5f);
        //float z = Random.Range(0.0f, 5.0f);
        if (m_targetCounter < 10)
        {

            Instantiate(target, position, Quaternion.identity);
            m_targetCounter += 1;
        }

    }
}
