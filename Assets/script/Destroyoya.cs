using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyoya : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject pearentObject;
    void Start()
    {
        foreach (Transform ChildTransform in pearentObject.transform)
        {
            Debug.Log(ChildTransform.gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int ObjCount = this.transform.childCount;
        if (ObjCount == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
