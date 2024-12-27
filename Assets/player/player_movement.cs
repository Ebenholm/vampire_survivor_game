using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public static player_movement player_movement_instance;
    public Rigidbody2D rb;
    public float player_speed = 2;
    private float x_input = 0;
    private float y_input = 0;
    private Vector2 move_dir = Vector2.zero;
    public float camera_stretch = 5;
    public Camera cam;

	private void Awake()
	{
		if(player_movement_instance == null)
        {
            player_movement_instance = this;
        }
	}
	// Start is called before the first frame update
	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        update_movement_dir();
    }
	private void FixedUpdate()
	{
        move_player();
        move_camera();
	}

    void update_movement_dir()
    {
        x_input = Input.GetAxisRaw("Horizontal");
        y_input = Input.GetAxisRaw("Vertical");
        move_dir = new Vector2 (x_input, y_input).normalized;
    }
    void move_player()
    {
		rb.velocity = move_dir * player_speed;
	}
    void move_camera()
    {
       
        Vector3 player_pos = rb.position;
        Vector3 cursor_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 camera_final_pos = (cursor_pos - player_pos).normalized;
        
        cam.transform.position = new Vector3(camera_final_pos.x * camera_stretch, camera_final_pos.y * camera_stretch, -10) + player_pos;

    }
}
