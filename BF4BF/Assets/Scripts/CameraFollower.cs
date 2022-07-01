using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    public float y;
    public float z;

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(0, y, -z);
    }
}
