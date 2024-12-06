using MovieStudio.Interfaces;
using MovieStudio.Staff.Team;
using MovieStudio.Thirdparty;
using System.Collections.Generic;

namespace MovieStudio.Staff
{
    public class StaffingService : IStaffingService
    {
        public List<StudioEmployee> Staff { get; private set; }

        public StaffingService()
        {
            Staff = new List<StudioEmployee>();
        }


        // Hiring actors
        public void HireActors(IEnumerable<IActor> actors)
        {
            foreach (var actor in actors)
            {
                Staff.Add(new Actor(actor.GetType().Name,true)); // Assigning a salary to Actor
            }
        }

        // Hiring cameramen
        public void HireCameramen(IEnumerable<ICameraman> cameramen)
        {
            foreach (var cameraman in cameramen)
            {
                Staff.Add(new CameraMan(cameraman.GetType().Name)); // Assigning a salary to Cameraman
            }
        }

        // Get all staff (actors + cameramen)
        public List<StudioEmployee> GetStaff()
        {
            return Staff;
        }
    }



}
