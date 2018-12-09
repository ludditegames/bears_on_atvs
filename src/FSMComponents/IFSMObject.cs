
public interface IFSMObject<StateEnum> {
    StateEnum ActiveState {get;}
    int ActiveStatePriority {get;}
    void SetActiveState(StateEnum ActiveState, int priority);
    void UnsetActiveState(int priority);
    void UpdateState(float delta);
    void ReactStateless(float delta);
    void ReactToState(float delta);
}