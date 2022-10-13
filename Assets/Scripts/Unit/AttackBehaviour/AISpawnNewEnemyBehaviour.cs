using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Attack/AISpawnNewEnemyBehaviour")]
public class AISpawnNewEnemyBehaviour:AttackBehaviour
{
    public int minDelay, maxDelay;
    public override void Init(Unit _unit)
    {
        unit=_unit;
        _transform=_unit.transform;
        _transform.GetComponent<Unit>().StartCoroutine(SpawnCoroutine());
    }
    public override void Attack()
    {
    }
    private void spawn()
    {
        if(Services.instance.Player==null) return;
        GameObject shot = GameObject.Instantiate(shotPrefab,_transform.position,Quaternion.identity);
     /*   Unit shotUnit = shot.GetComponent<Unit>();
        shotUnit.ForceInitBehaviours();
        shotUnit._moweBehaviour.SetTarget(Services.instance.Player.transform);
        shotUnit._rotationBehaviour.SetTarget(Services.instance.Player.transform);
        shotUnit._collisionBehaviour.AddIgnorableTag(TagsList.enemy);
        shotUnit._collisionBehaviour.AddIgnorableTag(TagsList.other);*/
    }
    private IEnumerator SpawnCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minDelay,maxDelay));
            spawn();
        }
    }
}
