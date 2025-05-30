using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private StateMachine stateMachine;
    public Rigidbody2D rb {  get; private set; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        stateMachine = gameObject.AddComponent<StateMachine>();
        stateMachine.SetState(new IdleState(stateMachine, this));
    }
}
