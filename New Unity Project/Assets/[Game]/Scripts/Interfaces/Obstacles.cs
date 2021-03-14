using System.Collections;
using System.Collections.Generic;
using Runner.Managers;
using UnityEngine;

public class Obstacles : MonoBehaviour,ICollectableObject
{
   public void Interaction()
   {
      EventManager.IsObstacleHit?.Invoke();
      Debug.Log("Crash !");
   }
}
