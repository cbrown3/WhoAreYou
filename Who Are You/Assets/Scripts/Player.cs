using UnityEngine;
using System;

namespace AssemblyCSharpEditor
{
	public class Player : MonoBehaviour
	{
		private int health;
		private int physicalDamage;
		private int rangeDamage;
		private int dodge;
		protected int experience;

        public Vector2 speed;
        private Vector2 position;
        public Vector2 mousePos;

        void Update()
        {
            //makes the character always facing the mouse
            mousePos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
            lookPos = lookPos - transform.position;
            float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            move();
            attack();
        }

		public Player ()
		{
			health = 10;
			physicalDamage = 5;
			rangeDamage = 5;
			dodge = 1;
			experience = 0;
            speed = new Vector2(2, 2);
            position = new Vector2(350, 300);
		}

		public int getHealth()
		{
			return health;
		}

		public int getPhysDamage()
		{
			return physicalDamage;
		}

		public int getRangeDamage()
		{
			return rangeDamage;
		}

		public int getDodge()
		{
			return dodge;
		}

		public int getExperience()
		{
			return experience;
		}

		public void move()
		{

            if(Input.GetKey("W"))
            {
                position.y -= speed.y;
            }
            
            if (Input.GetKey("A"))
            {
                position.x -= speed.x;
            }
            
            if (Input.GetKey("S"))
            {
                position.y += speed.y;
            }
            
            if (Input.GetKey("D"))
            {
                position.x += speed.x;
            }

            if(position.y <= 0)
            {
                position.y = 0;
            }

            if (position.y >= 600)
            {
                position.y = 600;
            }

            if (position.x <= 0)
            {
                position.x = 0;
            }

            if (position.x <= 700)
            {
                position.x = 700;
            }
		}

        void attack()
        {
            if(Input.GetMouseButton(0))
            {
                /*attack melee*/
            }
            else if (Input.GetMouseButton(1))
            {
                /*shoot ranged attack*/
            }
        }
	}
}

