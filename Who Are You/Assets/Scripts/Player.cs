using UnityEngine;
using System;

namespace AssemblyCSharpEditor
{
	public class Player : MonoBehaviour
	{
		protected string name;
		private int health;
		private int physicalDamage;
		private int rangeDamage;
		private int dodge;
		protected int experience;

        public Vector2 speed = new Vector2(2, 2);
        private Vector2 movement;

        void Update()
        {
        }

		public Player (string n)
		{
			name = n;
			health = 10;
			physicalDamage = 5;
			rangeDamage = 5;
			dodge = 1;
			experience = 0;
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

            }
		}
	}
}

