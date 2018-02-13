using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
/**
 *Author : Martin Johnson 
 */
public class Weapons : Items {
    /*
     * Plan : Code all weapon actions and attributs
     *
     * Attributs :  Ranged (true or false)
     *              weaponSize (small or regular)(modifies weight half weight when small)
     *              Damage (depends on size)
     *              weaponAttackType
     *              criticalMultiplier
     *              criticalRole (crit chance)
     *              weaponRange (base range + modifier)
     *              TwoHanded (true or false)
     *              SpecialEffect (magic, etc)
     *              Ammo?
     * 
     * Actions :    Attack()
     *              refine?
     *              etc.
     * 
     */


    void Awake() {

        ItemName = "BroadSword";
        GoldValue = 5;
        ItemType = "weapon";
        Weight = 5;
        Description = "This is a broadSword";
        Cost = 10;
        ThrowDamage = 2;

       // Printname();

        //Saves the item data on a file on the local computer
        /*
        BinaryFormatter bf = new BinaryFormatter();

        FileStream file = File.Create(Application.persistentDataPath + "/testWeapon.dat");
        Debug.Log(Application.persistentDataPath);
        WeaponData wData = new WeaponData();
        wData.itemName = ItemName;
        wData.goldValue = GoldValue;
        wData.itemType = ItemType;
        wData.weight = Weight;
        wData.description = Description;
        wData.cost = Cost;
        wData.throwDamage = ThrowDamage;

        bf.Serialize(file, wData);
        file.Close();
        */
    }
}

[Serializable]
class WeaponData {

    public string itemName = "";
    public int goldValue = 0;
    public string itemType = "";
    public int weight = 0;
    public string description = "";
    public int cost = 0;
    public int throwDamage = 0;

}
