using UnityEngine;

public class IdleState : State
{
    private PlayerController player;

    public IdleState(StateMachine stateMachine, PlayerController player) : base(stateMachine)
    {
        this.player = player;
    }

    public override void Tick()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (input != Vector2.zero)
        {
            stateMachine.SetState(new WalkState(stateMachine, player));
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.SetState(new AbilityState(stateMachine, player));
        }
    }
}
