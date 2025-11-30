using Microsoft.AspNetCore.SignalR;

namespace LiveCounter.Hubs;

public class UserHub : Hub
{
    private static int _counter = 0;

    public async Task NewWindowLoaded()
    {
        // Increment the counter
        Interlocked.Increment(ref _counter);
        
        // Notify all clients that a new window has been loaded with the updated count
        await Clients.All.SendAsync("WindowLoaded", _counter);
    }
}
