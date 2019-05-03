using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;	// A variable that stores a reference to our Player
    public Vector3 offset;      // A variable that allows us to offset the position (x, y, z)
    public Vector3 offset2;      // A variable that allows us to offset the position (x, y, z)

    // Update is called once per frame
    void Update()
    {
        // Set our position to the players position and offset it
         if (Time.fixedTime > 7 && Time.fixedTime < 10)
        {
            transform.position = player.position + offset2;

        }
         else transform.position = player.position + offset;
    }
}

