using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotScript : MonoBehaviour
{
    public Transform player;
    public float Smoothness = 5f;
    public Vector3 Offset = new Vector3(0, 0, 0);
    public GameObject ChatPanel;
    

    
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            OpenChat();
        }
        Movement();
        
    }

    private void OpenChat()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PlayerInput.Instance.ReleaseControl();
        Time.timeScale = 0;
        ChatPanel.SetActive(true);
    }
    
    public void CloseChat()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PlayerInput.Instance.GainControl();
        Time.timeScale = 1;
        ChatPanel.SetActive(false);
    }

    private void Movement()
    {
        Vector3 playerPosition = player.position;
        Vector3 targetPosition = playerPosition + player.right * Offset.x + player.up * Offset.y + player.forward * Offset.z ;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Smoothness * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, Smoothness * Time.deltaTime);
    }
}
