using MyPortfolio.Domain.DTO;

namespace MyPortfolio.Domain.Models.ViewModels
{
    public class UserInfoViewModel
    {
        public UserDto UserDTO { get; set; }

        public int YearsOfExperience { get; set; }

        public int TargetEndUsers { get; set; } = 10000;
        public int PlanningSessions { get; set; } = 1453;
        public int TeamMembers { get; set; } = 10;
    }
}
