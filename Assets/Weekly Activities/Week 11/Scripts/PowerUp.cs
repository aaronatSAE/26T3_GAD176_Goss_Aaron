using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    public int powerValue = 10;

    public abstract void Activate(); // Abstract method
}
