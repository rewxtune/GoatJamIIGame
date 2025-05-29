using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private StateMachine stateMachine;

    private void Start()
    {
        stateMachine = gameObject.AddComponent<StateMachine>();
        stateMachine.SetState(new IdleState(stateMachine, this));
    }
}
