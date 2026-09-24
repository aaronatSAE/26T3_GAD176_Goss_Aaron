using UnityEngine;

public class UnityEventSubscriber : MonoBehaviour
{
    private void OnEnable()
    {
        // Subscribe to the events we want to pay attention to.
        if (ExploringUnityEvents.onSpacebarPressed != null)
        {
            print("HI");
            ExploringUnityEvents.onSpacebarPressed.AddListener(PrintMessageToConsole);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //                                    vv
            ExploringUnityEvents.onSpacebarPressed?.Invoke();
            //                                    ^^
        }
    }

    private void OnDisable()
    {
        // Unsubscribe to all events we have subscribed to in OnEnable.
        if (ExploringUnityEvents.onSpacebarPressed != null)
        {
            print("BYE");
            ExploringUnityEvents.onSpacebarPressed.RemoveListener(PrintMessageToConsole);
        }
    }

    private void PrintMessageToConsole()
    {
        Debug.Log("Hello World from Events!");
    }
}
