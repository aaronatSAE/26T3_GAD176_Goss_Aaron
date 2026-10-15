using UnityEngine;

public class CompanionCube : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        Debug.Log("Companion Cube Collected!");
    }
}
