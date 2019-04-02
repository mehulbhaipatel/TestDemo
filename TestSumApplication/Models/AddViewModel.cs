using System.ComponentModel.DataAnnotations;

namespace TestSumApplication.Models
{
    public class AddViewModel
    {
        [Range(int.MinValue, int.MaxValue, ErrorMessage = "First number must be an integer number")]
        public int firstNumber { get; set; }
        [Range(int.MinValue, int.MaxValue, ErrorMessage = "Second number must be an integer number")]
        public int secondNumber { get; set; }
    }
}
