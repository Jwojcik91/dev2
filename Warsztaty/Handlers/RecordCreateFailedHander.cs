using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warsztaty.messages.Events;

namespace Warsztaty.API.Handlers
{
    public class RecordCreateFailedHander : IEventHandler<CreateRecordFailed>
	{
		public async Task HandleAsync(CreateRecordFailed @event)
		{
			Console.WriteLine($"Record: '{@event.Key}' was created.");
			await Task.CompletedTask;
		}
	}
}
