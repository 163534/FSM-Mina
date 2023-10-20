using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : StateMachine
{
    public float speed = 4f;
    public float jumpForce = 14f;
    public Rigidbody2D rigidbody;
    public SpriteRenderer spriteRenderer;

    [HideInInspector]
    public Idle idleState;
    [HideInInspector]
    public Moving movingState;
    [HideInInspector]
    public Jumping jumpingState;
    [HideInInspector]
    public Attack attackState;

    private void Awake()
    {
        idleState = new Idle(this);
        movingState = new Moving(this);
        jumpingState = new Jumping(this);
        attackState = new Attack(this);

    }

    protected override BaseState GetInitialState()
    {
        return idleState;
    }

    public void Test()
    {
        Debug.Log("test");
    }
}
