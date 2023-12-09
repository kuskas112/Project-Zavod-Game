using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundGame : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public RoundGraph RoundGraph;
    public static float rotation;
    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion rotationZ = Quaternion.AngleAxis(rotationSpeed, new Vector3(0,0,1));
        transform.rotation *= rotationZ;
        rotation = transform.rotation.eulerAngles.z;
    }
}
