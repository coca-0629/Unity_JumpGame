using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_ctrl : MonoBehaviour
{
    public Texture2D icon = null;           // add
    private float power;
    public float power_plus = 100.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))    
            power += power_plus * Time.deltaTime;
        if(Input.GetMouseButtonUp(0)) {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(power, power, 0));
            power = 0.0f;
        }
        if(this.transform.position.y < -5.0f || Input.GetMouseButtonDown(1))
            SceneManager.LoadScene("main");
    }

    // add function
    void OnGUI() {
        int power_int = (int)power;
        GUI.DrawTexture (new Rect(0, Screen.height - 64, 64, 64), icon);
        GUI.Label(new Rect(81, Screen.height - 40, 128, 32), "Jump Power: " + power_int.ToString());
    }
}
