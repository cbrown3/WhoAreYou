using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharpEditor
{
    public class Game : MonoBehaviour
    {
        Player p;

        List<WarEnemy> warriors;
        List<MageEnemy> mages;
        List<HoundEnemy> hounds;
        List<DemonEnemy> demons;

        int score;

        public Game()
        {
            Player p = new Player();

            warriors = new List<WarEnemy>();
            mages = new List<MageEnemy>();
            hounds = new List<HoundEnemy>();
            demons = new List<DemonEnemy>();
        }

        public void Update()
        {
            p.move();

            foreach(WarEnemy w in warriors)
            {
                w.move();
            }

            foreach (MageEnemy m in mages)
            {
                m.move();
            }

            foreach (HoundEnemy h in hounds)
            {
                h.move();
            }

            foreach (DemonEnemy d in demons)
            {
                d.move();
            }
        }

        public void CollisionDetection(Collision2D coll)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (coll.gameObject.tag == "WarEnemy")
                {
                    foreach (WarEnemy w in warriors)
                    {
                        w.health -= p.getPhysDamage();
                    }
                }

                if (coll.gameObject.tag == "MageEnemy")
                {
                    foreach (MageEnemy m in mages)
                    {
                        m.health -= p.getPhysDamage();
                    }
                }

                if (coll.gameObject.tag == "HoundEnemy")
                {
                    foreach (HoundEnemy h in hounds)
                    {
                        h.health -= p.getPhysDamage();
                    }
                }

                if (coll.gameObject.tag == "DemonEnemy")
                {
                    foreach (DemonEnemy d in demons)
                    {
                        d.health -= p.getPhysDamage();
                    }
                }
            }
        }
    }
}
