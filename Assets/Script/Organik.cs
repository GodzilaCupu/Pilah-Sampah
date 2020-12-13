using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organik : MonoBehaviour
{
    public Scoring score;
    public AudioSource audio1;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Organik"))
        {
            score.score += 100;
            audio1.Play();
            Destroy(GameObject.FindWithTag("Organik"));
        }
    }
}
