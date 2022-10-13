using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Collision/SelfDestroyTriggerBehaviour")]
public class SelfDestroyTriggerBehaviour : TriggerBehaviour
{
    [SerializeField] private float damage;
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if(CompareTag(collision.gameObject.tag))
        {
            collision.gameObject.GetComponent<Unit>().TakeDamage(unit.damage);
            unit.Kill();
        }
    }
    public override void Init(Unit _unit)
    {
        unit=_unit;
    }
}