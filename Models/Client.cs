
using System.Text;

namespace InformationSystem.Models
{
    public class Client
    {
        public int idClient { get; set; }
        public string passwordClient { get; set; }
        public string loginClient { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string city { get; set; }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat(" First Name  - {0} \n", firstName);
            str.AppendFormat(" Last Name  - {0} \n", lastName);
            str.AppendFormat(" Login  - {0} \n", loginClient);
            str.AppendFormat(" Email  - {0} \n", email);
            str.AppendFormat(" Phone Number  - {0} \n", phoneNumber);
            str.AppendFormat(" City  - {0} \n", city);

            return str.ToString();
        }
    }
}
