using UnityEngine;

/// <summary>
/// Will hold a list of all the cars that exist in the race.
/// </summary>
public class VehicleSpawner : MonoBehaviour
{
    [SerializeField] private Vehicle[] vehicleArray;

    private void Start()
    {
        vehicleArray[0].SetVehicleName("Chick Hicks");
    }
}
