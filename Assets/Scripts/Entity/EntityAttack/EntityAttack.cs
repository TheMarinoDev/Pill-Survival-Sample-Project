using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityAttack : ScriptableObject
{
    public int ID = 1;
    public float Cooldown = 1;
    public abstract void Execute(Entity entity);
}
