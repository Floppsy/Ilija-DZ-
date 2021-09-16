using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacija_ : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(0, 999, 0) * Time.deltaTime);
    }
}
