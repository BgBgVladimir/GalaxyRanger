using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Collision/ExplosiveCollisionBehaviour")]
public class ExplosiveCollisionBehaviour : CollisionBehaviour
{
    [SerializeField] private float damage;
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if(CompareTag(collision.gameObject.tag))
        {
            collision.gameObject.GetComponent<Unit>().TakeDamage(unit.damage);
            unit.Kill();
        }
    }
}