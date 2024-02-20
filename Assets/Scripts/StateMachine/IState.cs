
public interface IState
{
    public void Enter();
    public void Exit();
    public void HandleInput(); //State�� �Է�ó��
    public void Update();
    public void PhysicsUpdate();

}