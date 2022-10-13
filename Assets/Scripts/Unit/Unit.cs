using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Unit:MonoBehaviour
{
    [SerializeField] public int health  = 600;
    [SerializeField] public int damage  = 100;

    public MoweBehaviour _moweBehaviour;
    public RotationBehaviour _rotationBehaviour;
    public AttackBehaviour _attackBehaviour;
    public TriggerBehaviour _collisionBehaviour;
    public DestroyBehaviour _destroyBehaviour;

    private void Start()
    {
        Services.Units.Add(this);
    }
    private void Update()
    {
        ForceInitBehaviours();
        _rotationBehaviour?.Rotate();
        _moweBehaviour?.Update();
        _attackBehaviour?.Attack();
    }
    private void OnDisable()
    {
        Services.Units.Remove(this);
    }
    private void OnDestroy()
    {
        if(!this.gameObject.scene.isLoaded) return;
        ForceInitBehaviours();
        _destroyBehaviour?.OnUnitDestroy();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ForceInitBehaviours();
        _collisionBehaviour?.OnTriggerEnter2D(collision);
    }

    private ScriptableBehaviour InitBehaviour(ScriptableBehaviour behaviour)
    {
        ScriptableBehaviour newInstance=Instantiate(behaviour);
        newInstance.mainInstance=false;
        newInstance.Init(this);
        return newInstance;
    }

    public void ForceInitBehaviours()
    {
        if(_collisionBehaviour?.mainInstance==true)
            _collisionBehaviour=(TriggerBehaviour)InitBehaviour(_collisionBehaviour);

        if(_moweBehaviour?.mainInstance==true)
            _moweBehaviour=(MoweBehaviour)InitBehaviour(_moweBehaviour);

        if(_rotationBehaviour?.mainInstance==true)
            _rotationBehaviour=(RotationBehaviour)InitBehaviour(_rotationBehaviour);

        if(_attackBehaviour?.mainInstance==true)
            _attackBehaviour=(AttackBehaviour)InitBehaviour(_attackBehaviour);

        if(_destroyBehaviour?.mainInstance==true)
            _destroyBehaviour=(DestroyBehaviour)InitBehaviour(_destroyBehaviour);
    }

    public void Kill()
    {
        Destroy(this.gameObject);
    }
    public void TakeDamage(float damageAmount)
    {
        health-=(int)damageAmount;
        if(health<=0)
        {
            Kill();
        }
    }

}
