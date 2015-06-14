using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NameCreatorSample : MonoBehaviour
{
    void Start ()
    {
        AudioManager.Instance.PlayBGM (BGMName.thunderstorm1);
        SpriteLoad ();
        SpriteSampleCreate ();
        InvokeRepeating ("Test", 1, 1);
    }

    Dictionary<string, Sprite> _sprite = new Dictionary<string, Sprite> ();
    void SpriteLoad()
    {
        object[] _spriteList = Resources.LoadAll<Sprite> (MyResourcesPath.SPRITE);
        _sprite = new Dictionary<string, Sprite> ();
        foreach (Sprite sprite in _spriteList) {
            Debug.Log (sprite.name);
            _sprite [sprite.name] = sprite;
        }
    }

    void SpriteSampleCreate()
    {
        GameObject test = new GameObject ();
        test.AddComponent<SpriteRenderer> ();
        test.GetComponent<SpriteRenderer> ().sprite = _sprite [SpriteName.face];
    }

    void Test()
    {
        AudioManager.Instance.PlaySE (SEName.A1);
    }
}
