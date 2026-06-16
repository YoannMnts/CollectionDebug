using CollectionDebugger.Core;
using UnityEngine;
using UnityEngine.Serialization;

public class CustomWatch : MonoBehaviour
{
    [SerializeField] 
    private Transform[] customArray;
    private void Start()
    {
        var collectionWatch = new CustomCollectionWatch(nameof(customArray), customArray);
        collectionWatch.Watch();
    }
}