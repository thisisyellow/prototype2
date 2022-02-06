using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool isReadyForInstantiate;

    void Start()
    {
        isReadyForInstantiate = true;
    }

    void Update()
    {
        if (isReadyForInstantiate && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(PreventSpam());
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    IEnumerator PreventSpam()
    {
        isReadyForInstantiate = false;
        yield return new WaitForSeconds(2);
        isReadyForInstantiate = true;
    }
}
