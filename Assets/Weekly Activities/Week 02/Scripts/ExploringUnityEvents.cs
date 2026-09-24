using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;

public class ExploringUnityEvents : MonoBehaviour
{
    public static UnityEvent onSpacebarPressed = new UnityEvent();
    public static UnityEvent onEscapePressed = new UnityEvent();
    public static UnityEvent onHPressed = new UnityEvent();
    public static UnityEvent onPrimaryMouseButtonClicked = new UnityEvent();
    public static UnityEvent onShopOpened = new UnityEvent();
    public static UnityEvent onAimZoomInCompleted = new UnityEvent();
    public static UnityEvent onSongSkipped = new UnityEvent();
}
