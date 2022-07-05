using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PushTextOnScreen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<Text>().text = newQuestion;
        answerA.GetComponent<Text>().text = newA;
        answerB.GetComponent<Text>().text = newB;
        answerC.GetComponent<Text>().text = newC;
        answerD.GetComponent<Text>().text = newC;
    }
}
