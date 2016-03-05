using UnityEngine;
using System;

namespace AssemblyCSharpEditor
{
	public class MageEnemy : MonoBehaviour
	{
		private int health;
        private int damage;

        public Vector2 speed;
        private Vector2 position;

		public MageEnemy ()
		{
			health = 6;
            damage = 2;
		}

        public void Update()
        {
            move();
        }

        public void move()
        {
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(Input.mousePosition.x, Input.mousePosition.y),
                speed.x * Time.deltaTime);
        }
	}
}

