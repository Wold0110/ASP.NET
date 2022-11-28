using Valami.StudentsModel;

namespace Valami.Models
{
    public class HomeModel
    {
        StudentContext studentContext;

        public string Nevek = "Valter";
        public HomeModel()
        {
            studentContext = new StudentContext();
            
        }
    }
}
