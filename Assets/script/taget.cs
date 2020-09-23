using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taget : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    //的のスピード
    private float speed;
    //的の動く方向
    public Vector3 Direction;
    //的のプレハブ情報
    //public GameObject target;

    aimcontroller script;

    //動き
    public void Move()
    {
        transform.position += Direction * speed;
    }
    //衝突したら
    public void inplse()
    {
        
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
      
        //if()//

    }
    public void Hit()
    {
        Destroy(gameObject);

    }

}

