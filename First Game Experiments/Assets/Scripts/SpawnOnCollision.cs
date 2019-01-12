using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    bool bSpawnSelf = false;

    [SerializeField]
    bool bSpawnOther = false;

    [SerializeField]
    GameObject goSpawn;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            if (bSpawnSelf)
                Instantiate(goSpawn, transform.position, Quaternion.identity);
            if (bSpawnOther)
                Instantiate(goSpawn, collision.transform.position, Quaternion.identity);
        }
    }
}
