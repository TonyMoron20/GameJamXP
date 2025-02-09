using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cardPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CardSpawnRoutine());
    }

    private IEnumerator CardSpawnRoutine()
    {
        while (true)
        {
            int randomCard = Random.Range(0, _cardPrefab.Length);
            Instantiate(_cardPrefab[randomCard], new Vector3(-6.8f, 3.0f, 0.0f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
