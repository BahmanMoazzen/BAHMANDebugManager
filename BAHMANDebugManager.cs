using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BAHMANDebugManager : MonoBehaviour
{
    public static BAHMANDebugManager _Instance;
    Text _debugText;
    [SerializeField] bool _enableDebug = true;
    private void Awake()
    {


        if (_Instance == null)
        {
            _Instance = this;

            _debugText = GetComponentInChildren<Text>();
            _debugText.enabled = _enableDebug;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void _Log(string _text)
    {
        if (_enableDebug)
        {
            _debugText.text = _text;

        }
        Debug.Log(_text);
    }
}
