using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
//base class
public class Loot : ScriptableObject
{
   public Sprite lootSprite;
   public string lootName;
   public int dropChance;
   public GameObject lootPrefab;
   

   
    public Loot(string lootName, int dropChance)
    {
        this.lootName = lootName;
        this.dropChance = dropChance;
    }
}