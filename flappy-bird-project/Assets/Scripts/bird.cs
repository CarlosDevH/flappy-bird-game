using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rigidb;
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
       rigidb = GetComponent<Rigidbody2D>(); 

    }

    // Update is called once per frame
    void Update()
    {
        //fazendo passáro quicar
        if (Input.GetMouseButtonDown(0))
        {
            rigidb.velocity = Vector2.up * speed;
        }
    }
    void OnCollisionEnter2D(Collision2D colisor)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
