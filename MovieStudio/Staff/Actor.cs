﻿using MovieStudio.Interfaces;
using MovieStudio.Thirdparty;
using System;

namespace MovieStudio.Staff
{
    public class Actor : StudioEmployee, IActor
    {
        private readonly bool _isSuperStar;

        public Actor(string name, bool isSuperStar) : base(name, JobSalary.ACTOR)
        {
            _isSuperStar = isSuperStar;
        }

        public bool IsSuperStar()
        {
            return _isSuperStar;
        }
     
        // returns true if this actor plays nicely and there is no need to repeat the scene again
        public bool Act()
        {
            // superstar highly decreases a chance of failure
            bool generalSuccessChance = new Random().NextDouble() > 0.04;
            bool superStarSuccessChance = new Random().NextDouble() > 0.01;
            return _isSuperStar ? superStarSuccessChance : generalSuccessChance;
        }
    
       
    }
}
