using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PowerUp", menuName = "PowerUp/Create New PowerUp")]
public class PowerUp : ScriptableObject
{
    public int bulletSpeed;
    public int damage;
}
