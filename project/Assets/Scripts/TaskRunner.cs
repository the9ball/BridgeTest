using UnityEngine;

public class TaskRunner : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        IteratorTasks.Task.DefaultScheduler.Update();
    }
}
