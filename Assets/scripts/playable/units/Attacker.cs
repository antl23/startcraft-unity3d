using UnityEngine;
using System.Collections;

public class Attacker : Unit {

    //private void Update()
    //{
    //    AttackMove();
    //}
    //public override void AttackMove()
    //{
    //    if (this.tag != "player2" || Selected)
    //    {
    //        return;
    //    }

    //    Unit closestEnemy = ClosestEnemy();
    //    Building closestBuilding = ClosestBuilding();

    //    Playable closestTarget = null;
    //    float closestDistance = float.MaxValue;

    //    if (closestEnemy != null)
    //    {
    //        float enemyDistance = Vector3.Distance(this.transform.position, closestEnemy.transform.position);
    //        if (enemyDistance < closestDistance)
    //        {
    //            closestDistance = enemyDistance;
    //            closestTarget = closestEnemy;
    //        }
    //    }

    //    if (closestBuilding != null)
    //    {
    //        float buildingDistance = Vector3.Distance(this.transform.position, closestBuilding.transform.position);
    //        if (buildingDistance < closestDistance)
    //        {
    //            closestDistance = buildingDistance;
    //            closestTarget = closestBuilding;
    //        }
    //    }

    //    if (closestTarget != null)
    //    {
    //        isPatrolling = false;
    //        Attack(closestTarget);
    //    }
    //}
}



