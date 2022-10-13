using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/Player/Attack/PlayerPCAttackBehaviour")]
public class PlayerPCAttackBehaviour :AttackBehaviour
{
    [SerializeField] private TagFilter canAttackTag;

    public override void Init(Unit _unit)
    {
        unit=_unit;
        _transform=_unit.transform;
    }
    public override void Attack()
    {
        if(Input.GetMouseButtonDown(0))
        {
            createBullet();
        }
    }
    private void createBullet()
    {
        Transform targetTransform = getClickedObject(Services.MainCamera.ScreenToWorldPoint(Input.mousePosition));
        if(targetTransform==null) return;
        if(!canAttackTag.HasTag(targetTransform.tag)) return;

        GameObject shot = GameObject.Instantiate(shotPrefab,_transform.position,Quaternion.identity);
        Unit shotUnit = shot.GetComponent<Unit>();
        shotUnit.ForceInitBehaviours();
        shotUnit._moweBehaviour.SetTarget(targetTransform);
        shotUnit._rotationBehaviour.SetTarget(targetTransform);
        shotUnit._collisionBehaviour.AddIgnorableTag(TagsList.player);
        shotUnit._collisionBehaviour.AddIgnorableTag(TagsList.other);
    }
    private Transform getClickedObject(Vector2 attackPosition)
    {
        Collider2D colliders= Physics2D.OverlapPoint(attackPosition);
        if(colliders!=null)
        {
            return colliders.gameObject.transform;
        }
        return null;
    }
}
