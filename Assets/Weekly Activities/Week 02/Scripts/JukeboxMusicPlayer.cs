using UnityEngine;

public class JukeboxMusicPlayer : MonoBehaviour
{
    private void SongSkipped()
    {
        ExploringUnityEvents.onSongSkipped?.Invoke();
    }
}
