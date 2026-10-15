using UnityEngine;

public class Coin : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        // Do the collect stuff!
        // The coin should disappear.
        Debug.Log("COIN COLLECTED YAY");
        Destroy(gameObject);
    }
}
