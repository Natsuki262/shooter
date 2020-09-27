using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagetGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    //的のジェネレートするのに必要なデータ

    //生成するオブジェクトデータのプレハブ
    //[SerializeField] GameObject m_tageePrefab;
    //ウエーブとして生成するプレハブの配列
     [SerializeField] GameObject[] m_enemyPrefabs = null;

    //ウエーブとして生成するプレハブの配列

    //float m_timer = 0;//生成する時間？
    //float m_interval;//時間幅
    //public int m_counter = 1;
    int m_index = 0;//m_enemyPrefabsの添え字
    int m_enemyCounter;
    //[SerializeField] private GameObject pearentObject;


    //生成
    void Generate()
    {
        //if (m_timer > m_interval)
        //{

        //    {
        //        Instantiate(m_enemyPrefabs transform.position, transform.rotation);
        //        m_timer = 0;
        //        //Debug.Log(m_tageePrefab);
        //    }



        //}
        m_index++;
        if (m_index > 1)//配列の添え字が１より大きければ
        {
            m_index = 0;//添え字を０に戻す
        }
        Instantiate(m_enemyPrefabs[m_index]);//インスタンスを生成





    }
    void timer()
    {
        //m_timer += Time.deltaTime;
    }
    void Start()
    {
        //m_interval = 1f;
        Instantiate(m_enemyPrefabs[0]);
        Instantiate(m_enemyPrefabs[1]);
       
       

    }

    void Update()
    {
        timer();

        if (!GameObject.FindWithTag("target") && !GameObject.FindWithTag("Target1"))
        {

           Generate();
            Debug.Log("destroy");
            

        }
        /*if (!GameObject.FindGameobjectWithTag("ta") || GameObject.Find("Taget1,Target"))
        {

            //Generate();
            Debug.Log("destroy");

        }*/


    }

}



