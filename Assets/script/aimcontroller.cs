using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Texture2D cursor;
    public GameObject target;
    float mouse;
    void Start()
    {
        Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
        //cursorを自前のテクスチャデータに変更
        this.target = GameObject.Find("target");
    }

    // Update is called once per frame
    void Update()
    {
        //メイン📷上のマウスポインタからRayを飛ばす。
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        int layMask = 1;
        float maxDistance = 10;

        RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance, layMask);
        if (hit.collider)
        {
            Debug.Log(hit.collider.gameObject.name);
            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.green);
            mouse = Input.mousePosition.x;

            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("hit");
                Destroy(hit.collider.gameObject);
            }

        }
    }
}
