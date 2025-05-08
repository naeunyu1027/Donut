using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rigid;
    GameController gameController;

    
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        gameController = FindObjectOfType<GameController>();

    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(x * speed, rigid.velocity.y);
        ScreenChk();

        if (Input.GetButtonDown("Fire3"))
        {
            speed = 25f;
        }
        if (Input.GetButtonUp("Fire3"))
        {
            speed = 10f;
        }
    }

    private void ScreenChk() //카메라 안에 고정
    {
        Vector3 worlpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worlpos.x < 0.05f) worlpos.x = 0.05f;
        if (worlpos.x > 0.95f) worlpos.x = 0.95f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worlpos);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("donut"))
        {
            gameController.GetScore();
        }
        if (collision.gameObject.CompareTag("plusdonut"))
        {
            gameController.PlusGetScore();
        }
        if (collision.gameObject.CompareTag("dirtydonut"))
        {
            gameController.dirtyGetScore();
        }
    }
}

