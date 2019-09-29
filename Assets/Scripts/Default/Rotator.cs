using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classic
{
	public class Rotator : MonoBehaviour
	{

		public float speed;

		// Update is called once per frame
		void Update()
		{
			transform.Rotate(0f, speed * Time.deltaTime, 0f);
		}
	}
}
