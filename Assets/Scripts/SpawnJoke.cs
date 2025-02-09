using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnJoke : MonoBehaviour
{
    private Box box1;
    private Box box2;

    [SerializeField]
    private GameObject _objectJoke;

    private Joke _jokePrefab;

    private UIManager _uiManager;
    private GameManager _gameManager;

    private int combo = 0;

    public GameObject explosionPrefab;

    public scriptCombosV2 combosPrefab;

    private void Start()
    {
        box1 = GameObject.Find("Box1").GetComponent<Box>();
        box2 = GameObject.Find("Box2").GetComponent<Box>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _jokePrefab = GameObject.Find("JokePrefab").GetComponent<Joke>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void CheckBoxes()
    {
        int valueT = 0;

        if (box1._id != 0 && box2._id != 0)
        {
            valueT = box1._value + box2._value;
            Debug.Log($"Se spawneo el objeto {valueT}");
            _jokePrefab.ChangeSprite(valueT);

            Instantiate(explosionPrefab, new Vector3(1, -2, 0), Quaternion.identity);

            Clean();
            CardsDestroy(box1._nameObject, box2._nameAccesory);

            Debug.Log($"combo {combo}");

            if(box1._tagCard.Equals(_uiManager.objeto) && box2._tagCard.Equals(_uiManager.accesorio))
            {
                if(combo <= 3)
                {
                    combo += 1;
                    combosPrefab.nivelCombo = combo;
                }
                _gameManager.UpdateScore(10 * combo);
                Debug.Log("10 pts");
            }
            else if (box1._tagCard.Equals(_uiManager.objeto) || box2._tagCard.Equals(_uiManager.accesorio))
            {
                if(combo == 0)
                {
                    combo = 1;
                    combosPrefab.nivelCombo = combo;
                } 

                _gameManager.UpdateScore(5 * combo);
                Debug.Log("5 pts");
            }
            else
            {
                combo = 0;
                _gameManager.UpdateScore(0);
                Debug.Log("0 pts");
            }
        }
        else if(box1._id != 0 && box2._id == 0)
        {
            Debug.Log("Te hace falta colocar un accesorio");
        }
        else if (box1._id == 0 && box2._id != 0)
        {
            Debug.Log("Te hace falta colocar un objeto");
        }
        else
        {
            Debug.Log("Coloca algo en las casillas");
        }
    }

    private void Clean()
    {
        box1.CleanBox();
        box2.CleanBox();
    }

    public void CardsDestroy(string _object, string _accesory)
    {
        Destroy(GameObject.Find(_object));
        Destroy(GameObject.Find(_accesory));
    }
}