using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [SerializeField]public Text Scoretext;
    int score;
    [SerializeField] public GameObject taget_prefab; 
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }
    public void addScore()
    {
        score += 10;//addscore
        Scoretext.text = "Score" + score.ToString();
    }
}
