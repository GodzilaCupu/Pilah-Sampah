using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scoring : MonoBehaviour
{
    public GameObject[] winNews;

    public float score;

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Level 1")
        {
            if (score >= 200)
            {
                winNews[0].SetActive(true);
                Debug.Log("TestLvl1");
            }
        }else if (SceneManager.GetActiveScene().name == "Level 2")
        {
            if (score >= 300)
            {
                winNews[0].SetActive(true);
                Debug.Log("TestLvl2");
            }
        }
    }

}
