using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    [Header("Buttons' Panels RGB")]
    public GameObject answerABgBlue; //Blue is waiting
    public GameObject answerABgGreen; //Green is correct
    public GameObject answerABgRed; //Red is wrong

    public GameObject answerBBgBlue; //Blue is waiting
    public GameObject answerBBgGreen; //Green is correct
    public GameObject answerBBgRed; //Red is wrong

    public GameObject answerCBgBlue; //Blue is waiting
    public GameObject answerCBgGreen; //Green is correct
    public GameObject answerCBgRed; //Red is wrong

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




    public void AnswerA() //called on buttonA onClick
    {
        if (QuestionGenerator.actualAnswer == "A")
        {
            answerABgGreen.SetActive(true);
            answerABgBlue.SetActive(true);
            correctFX.Play();
        }
        else
        {
            answerABgRed.SetActive(true);
            answerABgBlue.SetActive(true);
            inCorrectFX.Play();
        }
        answerABtn.GetComponent<Button>().enabled = false;
        answerBBtn.GetComponent<Button>().enabled = false;
        answerCBtn.GetComponent<Button>().enabled = false;
        answerDBtn.GetComponent<Button>().enabled = false;

    }
    public void AnswerB() //called on buttonB onClick
    {
        if (QuestionGenerator.actualAnswer == "B")
        {
            answerBBgGreen.SetActive(true);
            answerBBgBlue.SetActive(true);
            correctFX.Play();
        }
        else
        {
            answerBBgRed.SetActive(true);
            answerBBgBlue.SetActive(true);
            inCorrectFX.Play();
        }
        answerABtn.GetComponent<Button>().enabled = false;
        answerBBtn.GetComponent<Button>().enabled = false;
        answerCBtn.GetComponent<Button>().enabled = false;
        answerDBtn.GetComponent<Button>().enabled = false;
    }

    public void AnswerC() //called on buttonC onClick
    {
        if (QuestionGenerator.actualAnswer == "C")
        {
            answerCBgGreen.SetActive(true);
            answerCBgBlue.SetActive(true);
            correctFX.Play();
        }
        else
        {
            answerCBgRed.SetActive(true);
            answerCBgBlue.SetActive(true);
            inCorrectFX.Play();
        }
        answerABtn.GetComponent<Button>().enabled = false;
        answerBBtn.GetComponent<Button>().enabled = false;
        answerCBtn.GetComponent<Button>().enabled = false;
        answerDBtn.GetComponent<Button>().enabled = false;
    }

    public void AnswerD() //called on buttonD onClick
    {
        if (QuestionGenerator.actualAnswer == "D")
        {
            answerDBgGreen.SetActive(true);
            answerDBgBlue.SetActive(true);
            correctFX.Play();
        }
        else
        {
            answerDBgRed.SetActive(true);
            answerDBgBlue.SetActive(true);
            inCorrectFX.Play();
        }
        answerABtn.GetComponent<Button>().enabled = false;
        answerBBtn.GetComponent<Button>().enabled = false;
        answerCBtn.GetComponent<Button>().enabled = false;
        answerDBtn.GetComponent<Button>().enabled = false;
    }
}
