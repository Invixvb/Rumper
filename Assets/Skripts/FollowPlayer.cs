using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

	public Transform targetplayer;
	public Vector3 offset;

	private void LateUpdate()
	{
		transform.position = targetplayer.position + offset;
	}
}
