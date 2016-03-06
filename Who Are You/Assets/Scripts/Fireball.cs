using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharpEditor
{
    class Fireball : MonoBehaviour
    {
        bool isActive;
        public Vector2 speed;
        private Vector2 position;

        public Fireball(GameObject obj)
        {
            isActive = false;
            speed = new Vector2(1.5f, 1.5f);
            position = obj.transform.position;
        }


    }
}
