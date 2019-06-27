// Renato Barbosa Candido - 1749978
// João Carlos Pirolo Filho - 1063898

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public float velShot;
    public GameObject explosionPrefab;
	public Transform explosionPoint;


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
        if (collision.gameObject.tag == "Player")
        {
			ContactPoint contact = collision.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			Instantiate(explosionPrefab,  collision.gameObject.transform.position, collision.gameObject.transform.rotation);
	        Destroy(this.gameObject);

        }else{
            Destroy(this.gameObject);
        }
    }
}
