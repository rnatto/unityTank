// Renato Barbosa Candido - 1749978
// João Carlos Pirolo Filho - 1063898

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{

    public float maxDistance = 10;
    public LayerMask layerMask;
    public RaycastHit hit;
    public GameObject parent;
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = parent.transform.forward;
        Debug.DrawRay(transform.position, direction * maxDistance, Color.green);
        if (Physics.Raycast (transform.position, direction, out hit, maxDistance, layerMask))
        {
            if(hit.collider.tag == "alvo")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
