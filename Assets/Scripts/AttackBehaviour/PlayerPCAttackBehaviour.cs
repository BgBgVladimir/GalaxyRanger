using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/Player/Attack/PlayerPCAttackBehaviour")]
public class PlayerPCAttackBehaviour :AttackBehaviour
{
    public override void Init(Transform transform)
    {
        _transform=transform;
    }
    public override void Attack()
    {
        if(Input.GetMouseButton(0))
        {
            GameObject shot = GameObject.Instantiate(shotPrefab,_transform.position,Quaternion.identity);
        }
    }
}
