using UnityEngine;

public class WalkState : State
{
    private PlayerController player;
    private float speed = 3f;

    public WalkState(StateMachine stateMachine, PlayerController player) : base(stateMachine)
    {
        this.player = player;
    }

    public override void Tick()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (input == Vector2.zero)
        {
            stateMachine.SetState(new IdleState(stateMachine, player));
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.SetState(new AbilityState(stateMachine, player));
            return;
        }

        // 2D Movement
        Vector2 move = input.normalized * speed * Time.deltaTime;
        player.transform.position += (Vector3)move;
    }
}
