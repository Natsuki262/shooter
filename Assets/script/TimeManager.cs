using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Text timeText;

    [SerializeField] float time = 60;
    [SerializeField] GameObject timeOvertext;
    void Start()
    {
        GameObject.Find("Timer").GetComponent<Text>().text = ((int)time).ToString();
        timeOvertext.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        timeLimit();
        Debug.Log(time);
    }
    public void timeLimit()
    {
        time -= Time.deltaTime;
        //マイナスは表示しないようにする
        GameObject.Find("Timer").GetComponent<Text>().text = ((int)time).ToString();
        if (time < 0)
        {
            time = 0;
            Debug.Log(time);
            timeOvertext.SetActive(true);

        }
    }
}
