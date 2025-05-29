using UnityEngine;

public class AbilityState : State
{
    private PlayerController player;
    private float timer = 0f;
    private float duration = 1f;

    public AbilityState(StateMachine stateMachine, PlayerController player) : base(stateMachine)
    {
        this.player = player;
    }

    public override void Enter()
    {
        Debug.Log("Using Ability!");
        timer = 0f;
    }

    public override void Tick()
    {
        timer += Time.deltaTime;

        if (timer >= duration)
        {
            stateMachine.SetState(new IdleState(stateMachine, player));
        }
    }

    public override void Exit()
    {
        Debug.Log("Ability Done");
    }
}
