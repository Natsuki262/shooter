using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Texture2D cursor;
    ///int mouse;
    void Start()
    {
        Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
        //cursorを自前のテクスチャデータに変更
    }

    // Update is called once per frame
    void Update()
    {
         //mouse= Input.mousePosition.x;

    }
}
