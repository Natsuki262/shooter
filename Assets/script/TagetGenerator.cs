using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagetGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    //的のジェネレートするのに必要なデータ

    //生成するオブジェクトデータのプレハブ
    [SerializeField] GameObject m_tageePrefab;
    float m_timer=0;//生成する時間？
    float m_interval;//z
    //public int m_counter = 1;

    //生成
    void Generate()
    {
        if(m_timer>m_interval)
        {
            m_timer = 0;
            Instantiate(m_tageePrefab);
            Debug.Log(m_tageePrefab);
        }
    }
    void timer()
    {
        m_timer += Time.deltaTime;
    }
    void Start()
    {
        m_interval = 1f; 
    }

    void Update()
    {
        timer();
        Generate();
    }

}



