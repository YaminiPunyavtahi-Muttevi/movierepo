using MovieStudio.Interfaces;
using MovieStudio.Thirdparty;
using System;

namespace MovieStudio.Staff
{
    public class CameraMan : StudioEmployee, ICameraman
    {
        public CameraMan(string name) : base(name, JobSalary.CAMERA_MAN)
        {

        }

        public bool Shoot()
        {
            return new Random().NextDouble() > 0.04;
        }

     
    }
}
