//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Enemy : Unit
//{
//    protected override void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.A)) AttackEverything();
//    }
//    private void AttackEverything() 
//    {
//        bool hasTarget = false;
//        Unit closestEnemy = ClosestEnemy();
//        Building closestBuilding = ClosestBuilding();

//        Playable closestTarget = null;
//        float closestDistance = float.MaxValue;

//        if (closestEnemy != null && !closestEnemy.CompareTag(this.tag))
//        {
//            float enemyDistance = Vector3.Distance(this.transform.position, closestEnemy.transform.position);
//            if (enemyDistance < closestDistance)
//            {
//                closestDistance = enemyDistance;
//                closestTarget = closestEnemy;
//                hasTarget = true;
//            }
//        }

//        if (closestBuilding != null && !closestBuilding.CompareTag(this.tag))
//        {
//            float buildingDistance = Vector3.Distance(this.transform.position, closestBuilding.transform.position);
//            if (buildingDistance < closestDistance)
//            {
//                closestDistance = buildingDistance;
//                closestTarget = closestBuilding;
//                hasTarget = true;
//            }
//        }

//        if (!hasTarget)
//        {
//            return;
//        }

//        if (this is Enemy)
//        {
//            isPatrolling = false;
//            goTo(closestTarget.transform.position);
//            return;
//        }
//    }
//}
