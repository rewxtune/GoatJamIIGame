using UnityEngine;
public class WalkState : State
{
    private PlayerController player;
    private float speed = 3f;
    private Vector2 direction;

    public WalkState(StateMachine stateMachine, PlayerController player) : base(stateMachine)
    {
        this.player = player;
    }

    public override void Tick()
    {
        // Input only (called from Update)
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        direction = input.normalized;

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
    }

    public override void FixedTick()
    {
        // Physics movement (called from FixedUpdate)
        Vector2 newPosition = player.rb.position + (direction * speed * Time.fixedDeltaTime);
        player.rb.MovePosition(newPosition);
    }
}
