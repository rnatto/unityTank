using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform tank;
    public Vector3 distancia;
    public float atraso;
    private int inverte;
    // Start is called before the first frame update
    void Start()
    {
        atraso = 1f;
    }

    // LateUpdate is called after Update
    void LateUpdate()
    {
        Vector3 posicaoCamera = tank.position + distancia;

        transform.position = Vector3.Lerp(transform.position, posicaoCamera, atraso);
        transform.LookAt(tank);
    }
}
