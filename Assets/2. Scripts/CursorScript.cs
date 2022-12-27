using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorScript : MonoBehaviour
{
    public static CursorScript cursor;

    [SerializeField] Texture2D defaultCursor;
    [SerializeField] Texture2D attackCursor;

    private void Awake()
    {
       if(cursor == null)
        {
            cursor = this;
        }
        DefautCursor();
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Battle")
        {
            AttackCursor();
        }
        else DefautCursor();
    }

    public void DefautCursor()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

     public void AttackCursor()
    {
        Cursor.SetCursor(attackCursor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
