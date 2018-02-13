using UnityEngine;
/**
 *Author : Martin Johnson 
 */
public class Items : MonoBehaviour{
    /*
     * Plan : Code all generic item actions and attributs
     *
     * Attributs :  Weight
     *              Gold Value
     *              Type
     *              name
     *              description
     *              cost //for the shopping
     *              throw damage //to implement later once items can be thrown
     *              
     *              
     * Actions :    pickUp() //pickup the item from current location
     *              drop() //drops the item on the floor
     *              trade() //Gives the item to another player (exchanges)
     *              throw(direction/target) // throws the item in that direction or at that target
     *              place(location) //puts item at location if possible
     *              lookAt() //returns description
     *              break() // breaks the item still in the game
     *              destroy() // destroy the item from the game
     *              Create() //Creates an instance of the item
     * 
     */

    #region variables
    private string itemName;
    private int goldValue;
    private string itemType;
    private int weight;
    private string description;
    private int cost;
    private int throwDamage;
    #endregion

    #region Setters
    public string ItemName {
        get {return itemName;}
        set {itemName = value;}
    }

    public int GoldValue {
        get {return goldValue;}
        set {goldValue = value;}
    }

    public string ItemType {
        get {return itemType;}
        set {itemType = value;}
    }

    public int Weight {
        get {return weight;}
        set {weight = value;}
    }

    public string Description {
        get {return description;}
        set {description = value;}
    }

    public int Cost {
        get {return cost;}
        set {cost = value;}
    }

    public int ThrowDamage {
        get {return throwDamage;}
        set {throwDamage = value;}
    }
#endregion

    public void Printname() {

        Debug.Log(itemName);

    }
}
