using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    #region Variables
    [Header("Buttons' Panels RGB for ---A---")]
    public GameObject answerABgBlue; //Blue is waiting
    public GameObject answerABgGreen; //Green is correct
    public GameObject answerABgRed; //Red is wrong

    [Header("Buttons' Panels RGB for ---B---")]
    public GameObject answerBBgBlue; //Blue is waiting
    public GameObject answerBBgGreen; //Green is correct
    public GameObject answerBBgRed; //Red is wrong

    [Header("Buttons' Panels RGB for ---C---")]
    public GameObject answerCBgBlue; //Blue is waiting
    public GameObject answerCBgGreen; //Green is correct
    public GameObject answerCBgRed; //Red is wrong

    [Header("Buttons' Panels RGB for ---D---")]
    public GameObject answerDBgBlue; //Blue is waiting
    public GameObject answerDBgGreen; //Green is correct
    public GameObject answerDBgRed; //Red is wrong

    [Header("Buttons' Components")]
    public GameObject answerABtn;
    public GameObject answerBBtn;
    public GameObject answerCBtn;
    public GameObject answerDBtn;

    [Header("Sound Effects")]
    public AudioSource correctFX;
    public AudioSource inCorrectFX;

    [Header("Score Details")]
    public GameObject currentScore;
    public int scoreValue;
    public int bestScore;
    public GameObject bestDisplay;

    [Header("Visuals")]
    public GameObject visual001;
    #endregion

    #region Start & Update
    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    private void Update()
    {
        currentScore.GetComponent<Text>().text = "Score: " + scoreValue;
    }
    #endregion

    public void Correct(GameObject answerGreen, GameObject answerBlue, bool state)
    {
        answerGreen.SetActive(state);
        answerBlue.SetActive(!state);
        correctFX.Play();
        scoreValue += 5;
    }

    public void Incorrect(GameObject answerRed, GameObject answerBlue, bool state)
    {
        answerRed.SetActive(state);
        answerBlue.SetActive(!state);
        inCorrectFX.Play();
        scoreValue = 0;
    }

    public void EnalbeDisableBtnComponent(  GameObject answerBtnAObj, 
                                            GameObject answerBtnBObj, 
                                            GameObject answerBtnCObj, 
                                            GameObject answerBtnDObj, 
                                            bool state)
    {
        answerBtnAObj.GetComponent<Button>().enabled = state;
        answerBtnBObj.GetComponent<Button>().enabled = state;
        answerBtnCObj.GetComponent<Button>().enabled = state;
        answerBtnDObj.GetComponent<Button>().enabled = state;  
    }


    public void AnswerA() //called on buttonA onClick
    {
        if (QuestionGenerator.actualAnswer == "A")
        {
            Correct(answerABgGreen, answerABgBlue, true);
        }
        else
        {
            Incorrect(answerABgRed, answerABgBlue, true);
        }

        EnalbeDisableBtnComponent(answerABtn, answerBBtn, answerCBtn, answerDBtn, false);
        StartCoroutine(NextQuestion());
    }
    public void AnswerB() //called on buttonB onClick
    {
        if (QuestionGenerator.actualAnswer == "B")
        {
            Correct(answerBBgGreen, answerBBgBlue, true);
        }
        else
        {
            Incorrect(answerBBgRed, answerBBgBlue, true);

        }
        EnalbeDisableBtnComponent(answerABtn, answerBBtn, answerCBtn, answerDBtn, false);
        StartCoroutine(NextQuestion());
    }
    public void AnswerC() //called on buttonC onClick
    {
        if (QuestionGenerator.actualAnswer == "C")
        {
            Correct(answerCBgGreen, answerCBgBlue, true);
        }
        else
        {
            Incorrect(answerCBgRed, answerCBgBlue, true);
        }

        EnalbeDisableBtnComponent(answerABtn, answerBBtn, answerCBtn, answerDBtn, false);
        StartCoroutine(NextQuestion());
    }
    public void AnswerD() //called on buttonD onClick
    {
        if (QuestionGenerator.actualAnswer == "D")
        {
            Correct(answerDBgGreen, answerDBgBlue, true);
        }
        else
        {
            Incorrect(answerDBgRed, answerDBgBlue, true);
        }

        EnalbeDisableBtnComponent(answerABtn, answerBBtn, answerCBtn, answerDBtn, false);
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion() //Used in Answer A B C D
    {
        if(bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = "BEST: " + scoreValue;
        }

        yield return new WaitForSeconds(1);
        //visual QuestionMark
        visual001.SetActive(false);
        //Green Panels
        answerABgGreen.SetActive(false);
        answerBBgGreen.SetActive(false);
        answerCBgGreen.SetActive(false);
        answerDBgGreen.SetActive(false);
        //Red Panels
        answerABgRed.SetActive(false);
        answerBBgRed.SetActive(false);
        answerCBgRed.SetActive(false);
        answerDBgRed.SetActive(false);
        //Blue Panels
        answerABgBlue.SetActive(true);
        answerBBgBlue.SetActive(true);
        answerCBgBlue.SetActive(true);
        answerDBgBlue.SetActive(true);
        //Enable Btns
        EnalbeDisableBtnComponent(answerABtn, answerBBtn, answerCBtn, answerDBtn, true);
        QuestionGenerator.displayingQuestion = false;
    }

    
}
