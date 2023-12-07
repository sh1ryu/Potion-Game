using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public List<GameObject> Items = new List<GameObject>();
    public float Force = 0.0f;
    public float Range = 0.0f;
    public float Delay = 1.0f;
        
    private float _time = 0.0f;
    void Update()
    {
        _time = _time + Time.deltaTime;
        if (_time > Delay)
        {
            _time = 0.0f;
            SpawnObject();
        }
    }
    private void SpawnObject()
    {
        var objectToSpawn = Items[Random.Range(0, Items.Count)];

        var spawnedObject = Instantiate(objectToSpawn);
        spawnedObject.transform.position = new Vector3(transform.position.x + Random.Range(-Range, Range), transform.position.y, transform.position.z);

        var spawnedObjectRigidbody = spawnedObject.GetComponent<Rigidbody>();
        spawnedObjectRigidbody.AddForce(transform.forward * Force, ForceMode.Impulse);
        spawnedObjectRigidbody.AddTorque(transform.forward * Force, ForceMode.Impulse);
    }
}
