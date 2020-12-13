using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scoring : MonoBehaviour
{
    public GameObject[] scoreText;
    public AudioSource audio;
    public GameObject[] winNews;

    private float x;
    void OnTriggerEnter(Collider bentuk)
    {
        
        #region Level1
        if(SceneManager.GetActiveScene().name == "Level 1")
        {
            x = 0;
            if (bentuk.CompareTag("Red"))
            {
                audio.Play();
                scoreText[0].SetActive(true);
                Destroy(GameObject.FindWithTag("Red"));

                x ++;

                Debug.Log("X = 1");
            }

            if (bentuk.CompareTag("LightBlue"))
            {
                audio.Play();
                scoreText[1].SetActive(true);
                Destroy(GameObject.FindWithTag("LightBlue"));

                x += 2;

                Debug.Log("X = 3");
            }

            if ( x >= 2 )
            {
                Cursor.lockState = CursorLockMode.Confined;
                Debug.Log("Winn");
                winNews[0].SetActive(true);
                Time.timeScale = 0;

            }
        }
        #endregion

        #region Level 3
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            x = 0;
            if (bentuk.CompareTag("Red"))
            {
                audio.Play();
                scoreText[0].SetActive(true);
                Destroy(GameObject.FindWithTag("Red"));

                x ++;

                Debug.Log("X = 1");
            }

            if (bentuk.CompareTag("LightBlue"))
            {
                audio.Play();
                scoreText[1].SetActive(true);
                Destroy(GameObject.FindWithTag("LightBlue"));

                x++;

                Debug.Log("X = 2");
            }

            if (bentuk.CompareTag("Pink"))
            {
                audio.Play();
                scoreText[1].SetActive(true);
                Destroy(GameObject.FindWithTag("Pink"));

                x+=2;

                Debug.Log("X = 4");
            }

            if (x >= 3)
            {
                Debug.Log("Winn");
                winNews[0].SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;
            }
        }
        #endregion

        #region Level 3
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            x = 0;
            if (bentuk.CompareTag("Red"))
            {
                audio.Play();
                scoreText[0].SetActive(true);
                Destroy(GameObject.FindWithTag("Red"));

                x ++ ;

                Debug.Log("X = 1");
            }

            if (bentuk.CompareTag("LightBlue"))
            {
                audio.Play();
                scoreText[1].SetActive(true);
                Destroy(GameObject.FindWithTag("LightBlue"));

                x++;

                Debug.Log("X = 2");
            }

            if (bentuk.CompareTag("Pink"))
            {
                audio.Play();
                scoreText[1].SetActive(true);
                Destroy(GameObject.FindWithTag("Pink"));

                x ++;

                Debug.Log("X = 3");
            }

            if (bentuk.CompareTag("Blue"))
            {
                audio.Play();
                scoreText[1].SetActive(true);
                Destroy(GameObject.FindWithTag("Blue"));

                x++;

                Debug.Log("X = 4");
            }
            if (bentuk.CompareTag("Green"))
            {
                audio.Play();
                scoreText[1].SetActive(true);
                Destroy(GameObject.FindWithTag("Green"));

                x+=2;

                Debug.Log("X = 6");
            }

            if (x >= 5)
            {
                Debug.Log("Winn");
                winNews[0].SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;
            }
        }
        #endregion



    }
}
