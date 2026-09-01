using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Enemy
    {
        public int damage;
        protected int ailevel;

        public virtual void Attack(Entity target)
        {

        }

        protected virtual void Patrol()
        {

        }
    }
}
