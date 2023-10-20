using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Attack : Grounded
{
    public Attack(PlayerScript stateMachine) : base("Attack", stateMachine) { }

    // same as Start()
    public override void Enter()
    {
        base.Enter();
        sm.spriteRenderer.color = Color.magenta;
        Debug.Log("Attack state entered");
        
    }
    // same as update()
    public override void UpdateLogic()
    {
        base.UpdateLogic();
        
            
    }
    // same as FixedUpdate()
    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("Attack state exited");
    }

}
