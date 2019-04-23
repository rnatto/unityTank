using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public float velShot;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        velShot += this.transform.localScale.x * 2;
        transform.Translate(new Vector3(0,0, velShot * Time.deltaTime));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "alvo")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
