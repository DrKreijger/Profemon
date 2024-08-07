using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfeMon
{
    public class Personnages
    {
        public string Name { get; set; }
        public int PV { get; set; }
        public bool IsStunned { get; set; }
        public bool IsDead { get; set; }
        public bool IsGuarding { get; set; }

        public Personnages()
        {
            this.Name = "Inconnu";
            this.PV = 100;
            this.IsStunned = false;
            this.IsDead = false;
        }

        public void ReceiveBigAttack()
        {
            if (!IsGuarding)
            {
                PV = PV - 20;
            }
            else
            {
                PV = PV - 15; //Dégats réduits si le joueur est en garde
            }
            if (PV <= 0)
            {
                Dead();
            }
        }
        public void ReceiveSimpleAttack()
        {
            if (!IsGuarding)
            {
                PV = PV - 10;
            }
            else
            {
                PV = PV - 5; //Dégats réduits si le joueur est en garde
            }

            if (PV <= 0)
            {
                Dead();
            }
        }

        public void Guard()
        {
            this.IsGuarding = true;
        }
        public void Dead()
        {
            this.IsDead = true;
        }

        public void Stunned()
        {
            this.IsStunned = true;
        }
    }
}
