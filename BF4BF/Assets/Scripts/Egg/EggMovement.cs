using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggMovement : MonoBehaviour
{
    public EggController eggController;

    [SerializeField] private float movementSpeedF = 40F;
    private float horizontalMovementF = 0f;
    private bool jumpB = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // Player Movement
        eggController.Move(horizontalMovementF, jumpB);
        jumpB = false;
    }

    public void Move(float axisValF)
    {
        horizontalMovementF = axisValF * movementSpeedF * Time.fixedDeltaTime;
    }

    public void Jump()
    {
        jumpB = true;
    }
}
