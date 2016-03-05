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

            List<WarEnemy> warriors = new List<WarEnemy>();
            List<MageEnemy> mages = new List<MageEnemy>();
            List<HoundEnemy> hounds = new List<HoundEnemy>();
            List<DemonEnemy> demons = new List<DemonEnemy>();
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


    }
}
