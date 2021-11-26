using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using Random = UnityEngine.Random;

public class MainScript : MonoBehaviour
{
    public static event Action wescored = delegate { };
    public static event Action healthman = delegate { };
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;

    int location = 2;


    public GameObject Ball1;
    public GameObject Ball2;
    public GameObject Ball3;


    int num1;
    int num2;

    string Question;

    int answer;
    int fakeAnswer1;
    int fakeAnswer2;

    int min1 = 1;
    int max1 = 20;

    int min2 = 3;
    int max2 = 15;

    int addNum1 = 5;
    int addNum2 = 4;

    public GameObject question;
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public GameObject wrong;

    int plus_minus;

    int x = 1;
    int y = 3;

    int answerLocation;


    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Player1.SetActive(false);
        Player2.SetActive(true);
        Player3.SetActive(false);

        Ball1.SetActive(false);
        Ball2.SetActive(false);
        Ball3.SetActive(false);

        wrong.SetActive(false);

        Q_A();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (location == 2)
            {
                LeftPlayer();
                location = 1;
            }
            else if (location == 3)
            {
                MiddlePlayer();
                location = 2;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (location == 2)
            {
                RightPlayer();
                location = 3;
            }
            else if (location == 1)
            {
                MiddlePlayer();
                location = 2;
            }
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void LeftPlayer()
    {
        Player1.SetActive(true);
        Player2.SetActive(false);
        Player3.SetActive(false);
    }

    public void MiddlePlayer()
    {
        Player1.SetActive(false);
        Player2.SetActive(true);
        Player3.SetActive(false);
        location = 2;
    }

    private void RightPlayer()
    {
        Player1.SetActive(false);
        Player2.SetActive(false);
        Player3.SetActive(true);
    }


    public void Q_A()
    {

        num1 = Random.Range(min1, max1);
        num2 = Random.Range(min2, max2);

        plus_minus = Random.Range(x, y);


        if (num1 >= num2 && plus_minus == 1)
        {
            Question = num1 + " - " + num2 + " " + "=";
            answer = num1 - num2;
            plus_minus = 2;
        }
        else if (num1 >= num2 && plus_minus == 2)
        {
            Question = num1 + " + " + num2 + " " + "=";
            answer = num1 + num2;
            plus_minus = 1;
        }
        else if (num1 <= num2 && plus_minus == 1)
        {
            Question = num2 + " - " + num1 + " " + "=";
            answer = num2 - num1;
            plus_minus = 2;
        }
        else if (num1 <= num2 && plus_minus == 2)
        {
            Question = num2 + " + " + num1 + " " + "=";
            answer = num2 + num1;
            plus_minus = 1;
        }

        question.GetComponent<Text>().text = Question;

        answerLocation = Random.RandomRange(1, 4);
        fakeAnswer1 = Random.RandomRange(answer - 5, answer + 10);
        fakeAnswer2 = Random.RandomRange(answer - 5, answer + 10);

        if (answer == fakeAnswer1)
        {
            fakeAnswer1 = Random.RandomRange(answer - 5, answer + 10);
        }
        else if (answer == fakeAnswer2)
        {
            fakeAnswer2 = Random.RandomRange(answer - 5, answer + 10);
        }
        else if (fakeAnswer2 == fakeAnswer1)
        {
            fakeAnswer2 = Random.RandomRange(answer - 5, answer + 10);
        }

        if (answerLocation == 1)
        {
            Answer1.GetComponent<Text>().text = answer.ToString();
            Answer2.GetComponent<Text>().text = fakeAnswer1.ToString();
            Answer3.GetComponent<Text>().text = fakeAnswer2.ToString();
        }
        else if (answerLocation == 2)
        {
            Answer1.GetComponent<Text>().text = fakeAnswer1.ToString();
            Answer2.GetComponent<Text>().text = answer.ToString();
            Answer3.GetComponent<Text>().text = fakeAnswer2.ToString();
        }
        else if (answerLocation == 3)
        {
            Answer1.GetComponent<Text>().text = fakeAnswer1.ToString();
            Answer2.GetComponent<Text>().text = fakeAnswer2.ToString();
            Answer3.GetComponent<Text>().text = answer.ToString();
        }



        min1 = ((min1 * 5) + addNum2) / 5;
        max1 = ((min1 * 4) + addNum1) / 4;

        min2 = ((min2 * 5) + addNum2) / 5;
        max2 = ((min2 * 4) + addNum1) / 4;

        addNum1 = addNum1 + 5;
        addNum2 = addNum2 + 3;
    }


    public void Shoot()
    {
        if (location == 1)
        {
            Ball1.SetActive(true);
            Ball2.SetActive(false);
            Ball3.SetActive(false);
        }
        else if (location == 2)
        {
            Ball1.SetActive(false);
            Ball2.SetActive(true);
            Ball3.SetActive(false);
        }
        else if (location == 3)
        {
            Ball1.SetActive(false);
            Ball2.SetActive(false);
            Ball3.SetActive(true);
        }

        if (answerLocation == location)
        {
            gameManager.Correct();
            wescored();
            WrongOff();
        }
        else
        {
            WrongOff();
            healthman();
            Wrong();
        }
    }

    public void Reset()
    {
        Ball1.SetActive(false);
        Ball2.SetActive(false);
        Ball3.SetActive(false);
    }

    public void Wrong()
    {
        wrong.SetActive(true);
    }

    public void WrongOff()
    {
        wrong.SetActive(false);
    }
}