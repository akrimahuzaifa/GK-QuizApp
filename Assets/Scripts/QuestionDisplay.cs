using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject screenQuestion;
    public GameObject answerABtnText;
    public GameObject answerBBtnText;
    public GameObject answerCBtnText;
    public GameObject answerDBtnText;

    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;
    public static bool update = false;

    private void Update()
    {
        if (!update)
        {
            update = true;
            StartCoroutine(PushTextOnScreen());
        }
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<Text>().text = newQuestion;
        answerABtnText.GetComponent<Text>().text = newA;
        answerBBtnText.GetComponent<Text>().text = newB;
        answerCBtnText.GetComponent<Text>().text = newC;
        answerDBtnText.GetComponent<Text>().text = newD;
    }
}
