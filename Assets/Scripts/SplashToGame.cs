using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashToGame : MonoBehaviour
{
    [Header("BackGrounds")]
    public GameObject bgm;
    public GameObject splashImage;
    public GameObject splashText;
    

    void Start()
    {
        StartCoroutine(SplashEnd());
    }

    IEnumerator SplashEnd()
    {
        yield return new WaitForSeconds(4);
        bgm.SetActive(true);
        yield return new WaitForSeconds(1);
        splashText.SetActive(false);
        splashImage.SetActive(false);
    }
}
