using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Champion", menuName = "ScriptableObjects/Champion")]

public class Champion : ScriptableObject
{
    public string name;
    public int level;
    public int health;
    public int mana;
    [Header("Stats")]
    public int attackDamage;
    public int magicDamage;
}
