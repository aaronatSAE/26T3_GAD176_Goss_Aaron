using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Primary script for cars in our high-speed, personification racing game.
/// </summary>
public class Vehicle : MonoBehaviour
{
    // Variables need:
    // - access modifier
    // - data type
    // - name
    // - value
    // access-modifier type name value
    [SerializeField] protected string carCharacterName = "Unnamed Car Character";
    private float accelerationRate = 30;
    private int wheelCount = 4;

    // Make a method to SET our name

    public void SetVehicleName(string newCarCharacterName)
    {
        carCharacterName = newCarCharacterName;
    }

    // Make a method to GET our name
}
