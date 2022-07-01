using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public Transform respawnPoint;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            // kill player
            Debug.Log("yeoch");
            col.transform.position = respawnPoint.transform.position;
        }
    }
}
