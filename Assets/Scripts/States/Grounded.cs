using UnityEngine;

public class Grounded : BaseState
{
    protected PlayerScript sm;

    public Grounded(string name, PlayerScript stateMachine) : base(name, stateMachine)
    {
        sm = (PlayerScript) this.stateMachine;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (Input.GetKeyDown(KeyCode.Space))
            stateMachine.ChangeState(sm.jumpingState);
    }

}
