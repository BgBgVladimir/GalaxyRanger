using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Attack/AIAttackPlayerBehaviour")]
public class AIAttackPlayerBehaviour:AttackBehaviour
{
    public int minDelay, maxDelay;
    public override void Init(Transform transform)
    {
        _transform=transform;
        transform.GetComponent<Unit>().StartCoroutine(attackCoroutine());
    }
    public override void Attack()
    {
    }
    private void createBullet()
    {
        GameObject shot = GameObject.Instantiate(shotPrefab,_transform.position,Quaternion.identity);
        Unit shotUnit = shot.GetComponent<Unit>();
        shotUnit._moweBehaviour.SetTarget(Services.instance.Player.transform);
        shotUnit._rotationBehaviour.SetTarget(Services.instance.Player.transform);
        shotUnit._collisionBehaviour.AddIgnorableTag(TagsList.enemy);
        shotUnit._collisionBehaviour.AddIgnorableTag(TagsList.other);
    }
    private IEnumerator attackCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minDelay,maxDelay));
            createBullet();
        }
    }
}
