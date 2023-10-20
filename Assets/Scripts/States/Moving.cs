using UnityEngine;

public class Moving : Grounded
{
    private float _horizontalInput;

    public Moving(PlayerScript stateMachine) : base("Moving", stateMachine) {}

    // same as Start()
    public override void Enter()
    {
        base.Enter();
        sm.spriteRenderer.color = Color.red;
        _horizontalInput = 0f;
    }
    // same as update()
    public override void UpdateLogic()
    {
        base.UpdateLogic();
        _horizontalInput = Input.GetAxis("Horizontal");
        if (Mathf.Abs(_horizontalInput) < Mathf.Epsilon)
            stateMachine.ChangeState(sm.idleState);
    }
    // same as FixedUpdate()
    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        Vector2 vel = sm.rigidbody.velocity;
        vel.x = _horizontalInput * ((PlayerScript)stateMachine).speed;
        sm.rigidbody.velocity = vel;
    }

}
