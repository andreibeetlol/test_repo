public class LifetimeTest : ILifetimeTest
{
    // Vream sa urmarim ca instantele s-au schimbat si initializam doar o singura data ID-ul
    public Guid InstanceId { get; } = Guid.NewGuid();
}