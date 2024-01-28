using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joke : MonoBehaviour
{
    public Sprite[] combinaciones;

    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    public void ChangeSprite(int id)
    {
        _sprite.sprite = combinaciones[id];
        _sprite.color = Color.white;
    }

    public void ShowJoke()
    {
        gameObject.SetActive(true);
    }
}
