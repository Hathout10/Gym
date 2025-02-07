using System.ComponentModel.DataAnnotations;

namespace GYM.System.PL.Dtos
{
	public class PlayerDto
	{
		[Required(ErrorMessage = "Name is required.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Phone number is required.")]
		[Phone(ErrorMessage = "Invalid phone number.")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "Adress is required.")]
		public string? Address { get; set; }
		[Required(ErrorMessage = "Gender is required.")]
		public string Gender { get; set; }

		[EmailAddress]
		public string Email { get; set; }


	}
}
