using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public Vector3 deslocamento;

    private void OnMouseDown()
    {
        deslocamento = transform.position - CoordMouseNoMundo();
    }

    Vector3 CoordMouseNoMundo()
    {
        Vector3 coordMouseNaTela = Input.mousePosition;
        coordMouseNaTela.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(coordMouseNaTela);
    }

    private void OnMouseDrag()
    {
        transform.position = CoordMouseNoMundo() + deslocamento;
    }


}
