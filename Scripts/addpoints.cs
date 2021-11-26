using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class addpoints : MonoBehaviour
{
    
    public int score;//this is the number with the game with clacualte behind the scene
    public TextMeshProUGUI scoretext;// this is what will be shown

    private void Awake()
    {
        MainScript.wescored += RunCo;
        scoretext = GetComponent<TextMeshProUGUI>();
    }


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
    }


    private IEnumerator Pulse()
    {
        for (float i =1f; i <=1.2f; i+= .05f)
        {
            scoretext.rectTransform.localScale = new Vector3(i,i,i);
        }
        scoretext.rectTransform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        score += 10;

        for (float i =1.2f; i>= 1f; i-=.05f)
        {
            scoretext.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForEndOfFrame();
        }
        scoretext.rectTransform.localScale = new Vector3(1f, 1f, 1f);

    }

    public void RunCo()
    {
        StartCoroutine(Pulse());

    }

    private void OnDestroy()
    {
        MainScript.wescored -= RunCo;


    }

   
}
