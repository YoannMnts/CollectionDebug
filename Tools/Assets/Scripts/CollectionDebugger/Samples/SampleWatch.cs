using CollectionDebugger.Core;
using UnityEngine;

public class SampleWatch : MonoBehaviour
{
    [SerializeField]
    private Transform[] sampleArray;

    private void Start()
    {
        sampleArray.Watch(nameof(sampleArray));
    }
}