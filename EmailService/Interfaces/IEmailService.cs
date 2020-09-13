using System.Threading.Tasks;

namespace Portfolio.Email
{
	public interface IEmailService
	{
		public Task SendAsync(EmailModel model);
	}
}