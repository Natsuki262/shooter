﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taget : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    //的のスピード
    public float speed;
    //的の動く方向
    public Vector3 Direction;
    //的のプレハブ情報
    //public GameObject target;

    aimcontroller script;
    [SerializeField] private GameObject pearentObject;
    //int score = 0;
  
    //動き
    public void Move()
    {
        transform.position += Direction * speed;
    }
    //衝突したら
    public void inplse()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }


    void Start()
    {

        //Instantiate(target); 
       


    }
    void Update()
    {
        Move();
    }
    private void OnDestroy()
    {
      
        

    }
    public void Hit()
    {
        // ターゲットに付いているコンポーネントによって処理を分けている
        ShootingTargetController target = GetComponent<ShootingTargetController>();
        if (target)
        {
            target.Hit();
        }
        else
        {
            Destroy(gameObject);
        }
        //score += 10;
        //Debug.Log(score);
        ScoreManager score = GameObject.Find("ScoreManeger").GetComponent<ScoreManager>();
        score.addScore();
        

    }

}

