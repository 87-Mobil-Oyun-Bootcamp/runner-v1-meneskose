using System.Collections;
using System.Collections.Generic;
using Runner.Managers;
using UnityEngine;

public class ShurikenItem : MonoBehaviour,ICollectableObject
{
    public void Interaction()
    {
        Destroy(gameObject);
        GameManager.ShurikenAmount += 1;
        EventManager.AddShuriken?.Invoke();
        Debug.Log("Shuriken Added");

    }
}