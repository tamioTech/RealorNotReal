using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnshopOwner : MonoBehaviour
{
    [SerializeField] GameObject ballObj;
    [SerializeField] Transform respawnPoint;

    SpriteRenderer ballSprite;
    Vector3 mousePosition;
    float deltaX;
    float deltaY;
    bool dragging;


    void Start()
    {
        ballSprite = ballObj.GetComponent<SpriteRenderer>();
        dragging = false;
    }
    void Update()
    {
        ResetPosition();
    }

    #region MouseStuff

    private void OnMouseOver()
    {
        if (dragging) { return; }
        ballSprite.color = Color.red;
    }

    private void OnMouseExit()
    {
        if (dragging) { return; }
        ballSprite.color = Color.white;
    }

    private void OnMouseDown()
    {
        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;

    }

    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
        dragging = true;
        ballSprite.color = Color.magenta;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
    #endregion

    private void ResetPosition()
    {
        if (!Input.GetKey(KeyCode.R)) { return; }
        ballObj.transform.position = respawnPoint.position;
    }


}
