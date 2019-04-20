using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform tank;
    public Vector3 distancia;
    public float atraso;

    // Start is called before the first frame update
    void Start()
    {
        distancia = new Vector3(tank.transform.position.x, 2f, -4f);
        atraso = 1f;
    }

    // LateUpdate is called after Update
    void LateUpdate()
    {
        distancia.x = transform.position.x - transform.position.x;
        Vector3 posicaoCamera = tank.position + distancia;
        transform.position = Vector3.Lerp(transform.position, posicaoCamera, atraso);
        transform.LookAt(tank);
    }
}
