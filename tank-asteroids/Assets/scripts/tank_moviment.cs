using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_moviment : MonoBehaviour {

    public GameObject cannon;
    public GameObject topCannon;

    public GameObject shot;
    public Transform posShot;
    public float velTopCannon = 2;
    float velTranslacao = 0.5f;
    float velRotacao = 0.5f;
    public float velCannonUp = 1;
    public float velCannonDown = 1;
    public float timerShot = 0;
    public float limitscaleShot = 0.3f;

    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame

	void Update () {
        move();

        scalePower();

        cannonMove();

        topCannonMove();

        Debug.Log("setas: " + Input.GetKey(KeyCode.LeftArrow));
        Debug.Log("setas: " + Input.GetKey(KeyCode.RightArrow));

        timerShot = timerShot < 1.5f && timerShot > 0 ? timerShot + Time.deltaTime : 0;
        if (Input.GetKeyDown(KeyCode.Space) && timerShot == 0 && transform.localScale.x > limitscaleShot)
        {
            timerShot += Time.deltaTime;
            Instantiate(shot, posShot.transform.position, posShot.transform.rotation);

        }
    }

    private void topCannonMove()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            topCannon.transform.Rotate(new Vector3(0, -velTopCannon, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            topCannon.transform.Rotate(new Vector3(0, velTopCannon, 0));
        }
    }

    private void cannonMove()
    {
        if (Input.GetKey(KeyCode.UpArrow) && cannon.transform.eulerAngles.z <= 40)
        {
            cannon.transform.Rotate(new Vector3(0, 0, velCannonUp));
        }
        if (Input.GetKey(KeyCode.DownArrow) && cannon.transform.eulerAngles.z >= 5)
        {
            cannon.transform.Rotate(new Vector3(0, 0, -velCannonDown));

        }
    }

    private void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -5, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 5, 0);
        }
    }

    private void scalePower()
    {
        if (Input.GetKey(KeyCode.Q) && transform.localScale.x < 2)
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }

        if (Input.GetKey(KeyCode.E) && transform.localScale.x > 0.2f)
        {
            transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
        }
    }
}
