using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(Random.Range(-6, 6), Random.Range(-6, 6));
    }
}
