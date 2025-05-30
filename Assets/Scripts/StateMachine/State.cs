public abstract class State : IState
{
    protected StateMachine stateMachine;

    protected State(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void Tick() { }
    public virtual void FixedTick() { }
}
