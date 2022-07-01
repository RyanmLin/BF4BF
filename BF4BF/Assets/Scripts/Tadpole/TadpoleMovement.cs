using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TadpoleMovement : MonoBehaviour
{
    public TadpoleController tadpoleController;

    [SerializeField] private float movementSpeedF = 40F;
    private float horizontalMovementF = 0f;
    private float verticalMovementF = 0f;
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
        tadpoleController.Move(horizontalMovementF);
        tadpoleController.Rise(verticalMovementF);
    }

    public void Move(float axisValF)
    {
        horizontalMovementF = axisValF * movementSpeedF * Time.fixedDeltaTime;
    }

    public void Rise(float axisValF)
    {
        verticalMovementF = axisValF * movementSpeedF * Time.fixedDeltaTime;
    }
}
