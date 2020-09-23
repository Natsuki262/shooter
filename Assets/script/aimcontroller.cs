using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEngine;

public class aimcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Texture2D cursor;
    [SerializeField] LayerMask m_targetLayer;
    //public GameObject target;
    public int m_bulletCount;

    //Debug
    float mouse;
    void Start()
    {
        Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
        //cursorを自前のテクスチャデータに変更
        //this.target = GameObject.Find("target");

        //弾の数の初期化
        m_bulletCount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //弾が一つもなければ
        /*if (m_bulletCount < 1)
        {
            return;

        }*/
        //リロードキーが押されかつ弾がゼロなら
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            m_bulletCount = 5;
            Debug.Log(m_bulletCount);
        }
        else if (m_bulletCount<1)
        {
            return;
        }


            if (Input.GetMouseButtonDown(0))
            {
                //残弾を減らす
                m_bulletCount -= 1;


                //メイン📷上のマウスポインタからRayを飛ばす。
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                float maxDistance = 10;

                RaycastHit2D   hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance, m_targetLayer);

            if (hit.collider)
            {
                Debug.Log(hit.collider.gameObject.name);
                Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.green);
                Debug.Log("hit");
                mouse = Input.mousePosition.x;
                //Destroy(hit.collider.gameObject);
               
                taget tgt = hit.collider.gameObject.GetComponent<taget>();
                //衝突したコンポーネントのスクリプト取得
                tgt.Hit();//targetスクリプトからHit関数

            }
        }

    }

    /*void aaa()内田先輩が書いたコード一例　参考
    {
        //クリックしたときに、targetの中にカーソルがあったら破壊する。
        //クリックするたびに残弾を減らす。
        //残弾がなくなったら打てない


        //クリックする
        if (Input.GetMouseButtonDown(0))
        {
            //残弾を減らす
            m_bulletCount--;

            //残弾がなければ何もしない
            if (m_bulletCount < 1)
            {
                return;
            }

            //残弾があればカーソルの位置にRayを飛ばす。
            //RAyCast~~~~

            //Rayの衝突判定
            if (true)
            {
                //RayがTargetに当たったら破壊
                //Targetの破壊処理
            }
        }
    }*/
}
