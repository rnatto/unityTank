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
    public float limitscaleShot = 0.3f;


    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame

	void Update () {
        move();

        //scalePower();

        cannonMove();

        topCannonMove();
        if (Input.GetKeyDown(KeyCode.Return) )
        {
            Instantiate(shot, posShot.transform.position, posShot.transform.rotation);
            shot.transform.localScale = transform.localScale/3;

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
        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(0, -5, 0);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0, 5, 0);
        }
    }

    private void scalePower()
    {
        if (Input.GetKey(KeyCode.Q) && transform.localScale.x < 0.8f)
        {
            transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        }

        if (Input.GetKey(KeyCode.E) && transform.localScale.x >= 0.4f)
        {
            transform.localScale += new Vector3(-0.02f, -0.02f, -0.02f);
        }
    }
}
