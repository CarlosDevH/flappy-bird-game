using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public gameController controller;

    void Start()
    {
        controller = FindObjectOfType<gameController>();
    }
    void OnTriggerEnter2D(Collider2D colisor){
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
    }
}
