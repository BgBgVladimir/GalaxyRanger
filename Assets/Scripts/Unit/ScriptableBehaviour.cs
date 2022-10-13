using UnityEngine;

public abstract class ScriptableBehaviour : ScriptableObject
{
    [HideInInspector]public Unit unit;
    [HideInInspector]public bool mainInstance=true;

    public virtual void Update()
    {
    }
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
    }
    public virtual void OnUnitDestroy()
    {

    }
    public abstract void Init(Unit _unit);
}
